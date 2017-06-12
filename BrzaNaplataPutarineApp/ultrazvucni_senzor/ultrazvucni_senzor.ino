const int trigPin=5;
const int echoPin=4;
int ledZelena=8;
int ledCrvena=9;

long duration;
int distance;

int info=0;

void setup() {
  // put your setup code here, to run once:
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);
  Serial.begin(9600);
}

int dajUdaljenost() {
  digitalWrite(trigPin, LOW);
  delayMicroseconds(2);

  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);

  duration = pulseIn(echoPin, HIGH);
  distance = duration*0.034/2;
  return distance;
}


void loop() {
  // put your main code here, to run repeatedly:


  //Serial.print("Udaljenost: ");
  //Serial.println(distance);


  if(Serial.available())
    info=Serial.parseInt();
  switch(info){
    case 1 : 
      Serial.println(dajUdaljenost());
      break;
    default :
      break;
  }
  
  info=0;
  
  distance = dajUdaljenost();
  digitalWrite(ledZelena, HIGH);

  if(distance < 15) {
    digitalWrite(ledZelena, LOW);
    digitalWrite(ledCrvena, HIGH);
    delay(3000);
    digitalWrite(ledCrvena, LOW);
    digitalWrite(ledZelena, HIGH);
    delay(3000);
  }
}
