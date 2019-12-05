
void setup()
{
    Serial.begin(115200);
    // x plane switches
    pinMode(40, INPUT_PULLUP);
    pinMode(41, OUTPUT);
    pinMode(46, INPUT_PULLUP);
    pinMode(47, OUTPUT);

    digitalWrite(41, LOW);
    digitalWrite(47, LOW);

    // Y plane switches
    pinMode(38, INPUT_PULLUP);
    pinMode(39, OUTPUT);
    pinMode(44, INPUT_PULLUP);
    pinMode(45, OUTPUT);

    digitalWrite(39, LOW);
    digitalWrite(45, LOW);
}

void loop()
{
    if(digitalRead(40) == 0)
    {
        Serial.println("Switch 1");
    }
    if(digitalRead(46) == 0)
    {
        Serial.println("Switch 2");
    }
    if(digitalRead(38) == 0)
    {
        Serial.println("Switch 3");
    }
    if(digitalRead(44) == 0)
    {
        Serial.println("Switch 4");
    }
}