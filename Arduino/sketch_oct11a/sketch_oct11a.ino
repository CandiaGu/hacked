#include <OrangutanAnalog.h>
#include <OrangutanLCD.h>
#include <OrangutanMotors.h>
#include <OrangutanPushbuttons.h>

OrangutanMotors motors;
OrangutanAnalog analog;
OrangutanLCD lcd;

int sensor1,sensor2;

void setup()                      // run once, when the sketch starts
{

  while (!OrangutanPushbuttons::isPressed(BUTTON_B))  // loop the code within { } until B is pressed
  {
    int bat = OrangutanAnalog::readBatteryMillivolts(); // declare an integer "bat" and set its value to the battery voltage
    lcd.clear();  // clear the lcd
    lcd.print(bat);  // write the value of integer "bat" to the lcd
    lcd.print("mV");  // write the text "mv" to the lcd
    lcd.gotoXY(0, 1);  // move the cursor to column 0 (the first column) of row 1 (the second row) of the lcd
    lcd.print("Press D");
    delay(100);  // pause here for 100 milliseconds
  }
  lcd.clear();  
}

void loop()                       // run over and over again
{
  int speed1 = 225;
  motors.setSpeeds(100,100);
  delay(100000);
 
} 
