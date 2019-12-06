#include <WiFi.h>
#include <WiFiUdp.h>
#include <WiFiAP.h>
#include <WiFiClient.h>
#include "EEPROM.h"
//#include <HardwareSerial.h>

const char* ssid = "DaVinciBot";
const char* password = "Ricktruvian";

bool paused;

uint32_t TransmitData(uint32_t lastAddr);

WiFiServer server(80);
WiFiClient client;
const int EEPROM_SIZE = 5000;

void setup()
{
  paused = false;
  
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

  pinMode(13, OUTPUT);
  digitalWrite(13, HIGH);
}

void loop()
{
	client = server.available();

	int addr = 0;
  bool down = false;

	if (client)
	{
		Serial.println("New client");
		String currentLine = "";
    client.println(EEPROM_SIZE);
//    if(!down)
//    {
//      Serial2.print("Z2.0\r\n");
//      down = true;
//    }
		while (client.connected())
		{
			if (client.available())
			{
				char c = client.read();
        //Serial.print(c);
				if (c == '\n') 
				{
					if (currentLine == "Transmission Complete")
					{
            //Serial.println("Transmission");
						EEPROM.commit();
						TransmitData(addr);
            Serial2.print("Z-2.0\r\n");
            down = false;
            client.println("Finished");
//						client.stop();
            
            for(int index = 0; index < EEPROM_SIZE; index++)
            {
              EEPROM.write(index, 0);
              EEPROM.commit();
            }
					}
          else if (currentLine == "Stop")
          {
            paused == true;
            continue;
          }
          else if (currentLine == "Resume")
          {
            paused == false;
            continue;
          }
          else if (currentLine == "Kill")
          {
            Serial2.print("G28\r\n");

//            client.stop();
            
            for(int index = 0; index < EEPROM_SIZE; index++)
            {
              EEPROM.write(index, 0);
            }
          }
					else if (!paused)
					{
						EEPROM.writeString(addr, currentLine + '\n');
						addr += currentLine.length() + 1;
           
						if (addr > EEPROM_SIZE)
						{
							EEPROM.commit();
							TransmitData(addr);
              addr = 0;

              for(int index = 0; index < EEPROM_SIZE; index++)
              {
                EEPROM.write(index, 0);
              }
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
  int count = 0;
	String instructions = "";
  String currentInst = "";
  Serial.print("Transmitting");

	Serial2.println("Instructions ready. Transmit?");

	while (address < lastAddr)
	{    
		instructions = EEPROM.readString(address);

    int index = 0;

    //while(!Serial2.available()) {}

    while(index < instructions.length())
    {
      while(!Serial2.available()) {}
      Serial2.read();

      if(count == 20)
      {
        client.println();
        count = 0;
      }

      count++;
      
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
