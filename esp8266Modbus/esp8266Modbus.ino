#include <ESP8266WiFi.h>
#include <ModbusIP_ESP8266.h>
#include <DHTesp.h>


const char* ssid = "SEBRATEL_ANDERSON";
const char* password = "orelhano";

//const char* ssid = "anderson";
//const char* password = "shakma1510";

//const char* ssid = "DIRECT-NS-anderson";
//const char* password = "anderson1510";

ModbusIP mb;
DHTesp dht;

// endereço dos registradores
const int REG = 0;
unsigned long lastRead = 0;
const int REG_CMD  = 1;   // comando vindo do mestre
const int PIN_OUT = 5;    // GPIO5 (D1)

void setup() {
  Serial.begin(115200);

  WiFi.begin(ssid, password);

  CheckWifiStatus();

  ConfigureModBusConnection();
}

void loop() {
   mb.task();

  // leitura do comando vindo do mestre para acionar a saída
  int command = mb.Hreg(REG_CMD);

  if (command == 1) {
    digitalWrite(PIN_OUT, HIGH);
  } else {
    digitalWrite(PIN_OUT, LOW);
  }

  TemperatureSender();
}

void ConfigureModBusConnection()
{
  mb.server();

  mb.addHreg(REG, 0);  // temperatura
  mb.addHreg(REG_CMD, 0);   // comando de ligar saída

  pinMode(PIN_OUT, OUTPUT);

  dht.setup(2, DHTesp::DHT11);
}

void CheckWifiStatus()
{
  while (WiFi.status() != WL_CONNECTED) 
  {
    Serial.println("Conectando...");
    delay(500);
  }

  Serial.println("\nWiFi conectado!");
  Serial.print("IP do ESP: ");
  Serial.println(WiFi.localIP());
}

void TemperatureSender()
{
  // leitura do sensor de temperatura
  if (millis() - lastRead > 1000) {
    lastRead = millis();

    TempAndHumidity data = dht.getTempAndHumidity();

    ErrorVizualizator(data); // serial - não aplicavel ao modbus

    PrintTemperature(data); // serial - não aplicavel ao modbus

    mb.Hreg(REG, (int)data.temperature);
  }

  return;
}

void PrintTemperature(TempAndHumidity data)
{
    Serial.print("Temp: ");
    Serial.print(data.temperature);
    Serial.println(" °C");
}

void ErrorVizualizator(TempAndHumidity data)
{
  if (isnan(data.temperature) || isnan(data.humidity)) {
      Serial.println("Erro ao ler DHT11");
      return;
    }

  return;  
}