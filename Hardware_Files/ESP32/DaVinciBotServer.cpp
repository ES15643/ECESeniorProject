#include <WiFi.h>
#include <WiFiUdp.h>
#include "EEPROM.h"

const char* ssid = "NetworkName";
const char* password = "NetworkPassword";

WiFiServer server(3333);
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

	Serial.println();
	Serial.print("Connecting to ");
	Serial.print(ssid);

	WiFi.begin(ssid, password);

	while (WiFi.status() != WL_CONNECTED)
	{
		delay(500);
		Serial.print(".");
	}

	Serial.println("");
	Serial.println("WiFi connected");
	Serial.println("IP address: ");
	Serial.println(WiFi.localIP());

	server.begin();
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
						client.println("Connect to DaVinci Bot? Y/N");
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
