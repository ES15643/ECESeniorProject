#include <WiFi.h>
#include <WiFiUdp.h>
#include <WiFiAP.h>
#include <WiFiClient.h>
#include "EEPROM.h"

const char* ssid = "DaVinciBot";
const char* password = "NetworkPassword";

WiFiServer server(80);
#define EEPROM_SIZE 10000

void setup()
{
	Serial.begin(115200);
	Serial.println("\nTesting EEPROM Library\n");
	if (!EEPROM.begin(EEPROM_SIZE)) {
		Serial.println("Failed to initialise EEPROM");
		Serial.println("Restarting...");
		delay(1000);
		ESP.restart();
	}

	delay(10);

	Serial.println("Configuring access point...");

	WiFi.softAP(ssid, password);
	IPAddress addr = WiFi.softAPIP();
	Serial.print("AP IP address: ");
	Serial.println(addr);
	
	server.begin();

	Server.println("Server started");
}

void loop()
{
	WiFiClient client = server.available();

	bool receivingCmds = false;
	int addr = 0;

	if (client && !receivingCmds)
	{
		Serial.println("New client");
		String currentLine = "";
		while (client.connected())
		{
			if (client.available())
			{
				char c = client.read();
				//Serial.write(c);
				if (c == '\n')
				{
					if (currentLine == "Transmission Complete")
					{
						EEPROM.commit();
						TransmitData(addr);
						client.stop();
						break;
					}
					if (currentLine.length() == 0 && !receivingCmds)
					{
						client.print(EEPROM_SIZE);
					}
					else
					{
						if (receivingCmds)
						{
							EEPROM.writeString(addr, currentLine);
							addr += currentLine.length();
							if (addr > EEPROM_SIZE)
							{
								EEPROM.commit();
								TransmitData(addr);
							}
						}
						currentLine = "";
					}
				}
				else if (c != '\r')
				{
					currentLine += c;
				}

				if (currentLine == "Y")
				{
					receivingCmds = true;
				}
				else 
				{
					continue;
				}
			}
		}
	}
}

uint32_t TransmitData(uint32_t lastAddr)
{
	Serial2.begin(115200);
	int address = 0;
	String currentInst = "";

	Serial2.println("Instructions ready.  Transmit?");

	while (address < lastAddr)
	{
		if (Serial2.available())
		{
			currentInst = EEPROM.readString(address);
			Serial2.println(currentInst);
			address += currentInst.length();
		}
	}

	return address;
}
