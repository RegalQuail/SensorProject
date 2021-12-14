int analogPin = A3;
int val = 0;
float vol = 0.0;
float resistance = 0.0;
float Temp = 37.5;
float NewTemp = 0.0;
float a = -1.26;

void setup() {
  Serial.begin(9600);
  Serial.println("Vores spændingsomregner !");
}

void loop() {
  delay(3000);
  val = analogRead(analogPin);
  vol = val * 0.0049;
  resistance = (vol * 10) / (5 - vol);
  NewTemp = Temp + (resistance * (a));
  Serial.println("Værdi i Bits:");
  Serial.println(val);
  Serial.println("Værdi i Volts:");
  Serial.println(vol);
  Serial.println("Resistance:");
  Serial.println(resistance);
  Serial.println("Termometer:");
  Serial.println(NewTemp);
  Serial.println("--------------");
}
