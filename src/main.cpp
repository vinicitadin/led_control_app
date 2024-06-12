#include <Arduino.h>
#include <BqBusSerial.h>

BqBusSerial pc(1);

void setup() {
  Serial.begin(9600);
  pc.setBus(&Serial);
  pinMode(LED_BUILTIN, OUTPUT);
}

void loop() {
  pc.communicationTask();

  int button = pc.getReg(0);

  digitalWrite(LED_BUILTIN, button);
}