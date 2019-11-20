#include <WiFi.h>
#include <WiFiUdp.h>

const char* ssid = "NetworkName";
const char* password = "NetworkPassword";

WiFiServer server(3333);

void setup()
{
  Serial.begin(115200);

  delay(10);

  Serial.println();
  Serial.print("Connecting to ");
  Serial.print(ssid);

  WiFi.begin(ssid.password);

  while(WiFi.status() != WL_CONNECTED)
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

  if(client)
    {
      Serial.println("New client");
      String currentLine = "";
      while(client.connected())
	{
	  if(client.available())
	    {
	      char c = client.read();
	      Serial.write(c);
	      if(c == '\n')
		{
		  
		}
	    }
	}
    }
}
