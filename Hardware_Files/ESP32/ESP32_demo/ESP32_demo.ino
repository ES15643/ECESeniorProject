#include <WiFi.h>
#include <EEPROM.h>
 
const char* ssid = "GreenOrb"; // Network Name
const char* password =  "windsor28081"; // Password to Network
int status = WL_IDLE_STATUS;
const int LED_PIN = 13;
const int port = 80;

// WiFiUDP server;
WiFiServer server(23);
 
void setup()
{
    pinMode(LED_PIN, OUTPUT);
    Serial.begin(115200);
//   Serial.println("Attempting to Connect to Network...");
//   Serial.print("SSID: ");
//   Serial.println(ssid);

//   status = WiFi.begin(ssid, password);
    connectToWiFi(ssid, password);
    server.begin();

    //UDP
    // server.begin(port);
}
 
void loop()
{
    char temp;
    WiFiClient client = server.available();
    if (client.connected())
    {
        Serial.println("Client Connected....");
        temp = client.read();
        Serial.print(temp);
        server.write(temp);
    }

    // if there's data available, read a packet
    // int packetSize = Udp.parsePacket();
    // if (packetSize) 
    // {
    //     Serial.print("Received packet of size ");
    //     Serial.println(packetSize);
    //     Serial.print("From ");
    //     IPAddress remoteIp = Udp.remoteIP();
    //     Serial.print(remoteIp);
    //     Serial.print(", port ");
    //     Serial.println(Udp.remotePort());

    //     // read the packet into packetBufffer
    //     int len = Udp.read(packetBuffer, 255);
    //     if (len > 0) 
    //     {
    //         packetBuffer[len] = 0;
    //     }
    //     Serial.println("Contents:");
    //     Serial.println(packetBuffer);

    //     // send a reply, to the IP address and port that sent us the packet we received
    //     Udp.beginPacket(Udp.remoteIP(), Udp.remotePort());
    //     Udp.write(ReplyBuffer);
    //     Udp.endPacket();
    // }
}

void connectToWiFi(const char * ssid, const char * pwd) // From Sparkfun tutorial
{
    int ledState = 0;
    Serial.println("Connecting to WiFi network: " + String(ssid));

    WiFi.begin(ssid, pwd);

    while (WiFi.status() != WL_CONNECTED) 
    {
        // Blink LED while we're connecting:
        digitalWrite(LED_PIN, ledState);
        ledState = (ledState + 1) % 2; // Flip ledState
        delay(500);
        Serial.print(".");
    }

    Serial.println();
    digitalWrite(LED_PIN, HIGH);
    Serial.println("WiFi connected!");
    Serial.print("IP address: ");
    Serial.println(WiFi.localIP());
}