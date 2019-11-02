#include <WiFi.h>
#include <EEPROM.h>
 
const char* ssid = "Kow"; // Network Name
const char* password =  "f3g2f563crdi3"; // Password to Network
int status = WL_IDLE_STATUS;

WiFiServer server(80);
 
void setup()
{
  Serial.begin(9600);
  Serial.println("Attempting to Connect to Network...");
  Serial.print("SSID: ");
  Serial.print(ssid);

  status = WiFi.begin(ssid, password);
  if( status != WL_CONNECTED)
  {
      Serial.println("Couldn't connect to Wifi");
      while(true);
  }
  else
  {
      server.begin();
      Serial.print("Connected to: ");
      IPAddress myIP = WiFi.localIP();
      Serial.println(myIP);
  }
}
 
void loop()
{
    char temp;
    WiFi.Client client = server.available();
    if (client.connected())
    {
        Serial.println("Client Connected....");
        temp = client.read();
        Serial.print(temp);
        server.write(temp);
    }
}