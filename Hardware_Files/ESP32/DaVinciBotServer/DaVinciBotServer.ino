#include <WiFi.h>
#include <WiFiUdp.h>
#include <WiFiAP.h>
#include <WiFiClient.h>
#include "EEPROM.h"
#include <HardwareSerial.h>

const char* ssid = "DaVinciBot";
const char* password = "Ricktruvian";

uint32_t TransmitData(uint32_t lastAddr);

WiFiServer server(80);
const int EEPROM_SIZE = 10000;

void setup()
{
	Serial.begin(115200);
  Serial2.begin(115200); 
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

	Serial.println("Server started");
}

void loop()
{
	WiFiClient client = server.available();

	int addr = 0;

	if (client)
	{
		Serial.println("New client");
		String currentLine = "";
    client.print(EEPROM_SIZE);
		while (client.connected())
		{
			if (client.available())
			{
				char c = client.read();
//				Serial.print(c);
				if (c == '\n')
				{
					if (currentLine == "Transmission Complete")
					{
						EEPROM.commit();
						TransmitData(addr);
						client.stop();
					}
					else
					{
						EEPROM.writeString(addr, currentLine + '\n');
						addr += currentLine.length() + 1;
           
						if (addr > EEPROM_SIZE)
						{
							EEPROM.commit();
							TransmitData(addr);
              addr = 0;
						}
           
						currentLine = "";
					}
				}
				else if (c != '\r')
				{
					currentLine += c;
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
	int address = 0;
	String instructions = "";
  String currentInst = "";

	Serial2.println("Instructions ready.  Transmit?");

	while (address < lastAddr)
	{    
		instructions = EEPROM.readString(address);

    int index = 0;

    while(index < instructions.length())
    {
      while(!Serial2.available()) {}
      Serial2.readString();

      currentInst = instructions.substring(index, instructions.indexOf('\n', index));

      currentInst.trim();
      currentInst.replace("\n", "");
      currentInst.replace("\r", "");
      currentInst.replace("\0", "");
      
      currentInst += "\r\n";
      
      Serial2.print(currentInst);

      index += currentInst.length() - 1;  
    }
    
		address += instructions.length();
	}

	return address;
}
