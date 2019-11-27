
void setup()
{
    Serial.begin(115200);
    pinMode(21, INPUT_PULLUP);
    pinMode(3, INPUT_PULLUP);
    pinMode(18, INPUT_PULLUP);
    pinMode(19, INPUT_PULLUP);

    pinMode(22, OUTPUT);
    pinMode(4, OUTPUT);
    pinMode(17, OUTPUT);
    pinMode(20, OUTPUT);

    digitalWrite(22, LOW);
    digitalWrite(4, LOW);
    digitalWrite(17, LOW);
    digitalWrite(20, LOW);
}

void loop()
{
    if(digitalRead(21) == 0)
    {
        Serial.println("Switch 1");
    }
    if(digitalRead(3) == 0)
    {
        Serial.println("Switch 2");
    }
    if(digitalRead(18) == 0)
    {
        Serial.println("Switch 3");
    }
    if(digitalRead(19) == 0)
    {
        Serial.println("Switch 4");
    }
}