
void setup()
{
    Serial.begin(115200);
    pinMode(22, INPUT_PULLUP);
    pinMode(24, INPUT_PULLUP);
    pinMode(26, INPUT_PULLUP);
    pinMode(28, INPUT_PULLUP);

    pinMode(23, OUTPUT);
    pinMode(25, OUTPUT);
    pinMode(27, OUTPUT);
    pinMode(29, OUTPUT);

    digitalWrite(23, LOW);
    digitalWrite(25, LOW);
    digitalWrite(27, LOW);
    digitalWrite(29, LOW);
}

void loop()
{
    if(digitalRead(22) == 0)
    {
        Serial.println("Switch 1");
    }
    if(digitalRead(24) == 0)
    {
        Serial.println("Switch 2");
    }
    if(digitalRead(26) == 0)
    {
        Serial.println("Switch 3");
    }
    if(digitalRead(28) == 0)
    {
        Serial.println("Switch 4");
    }
}