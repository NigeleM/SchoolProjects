
/* 
 * File:   Car.h  
 * Author: nigele mccoy
 * DR. Atluri CIS 215
 * Car Program
 * Created on February 6, 2019, 4:18 PM
 */



#include <iostream>
#include <cstdlib>
#include "Car.h"

using namespace std;

int main()
{
        // Declaring variables 
	bool on;
	bool off;
        int direction;
        Car toyota;
        
	on = toyota.start();
	// Checking to see if the car is on
	if(on == true)
		cout << "Car is on \n"; 
	else
		cout << "Car is not on \n";
	
        // Moving the car from 0 to 80 mph
	toyota.accelerate(80);
	toyota.getSpeed();
	// Slowing the car down by 15 mph
        toyota.brake(15);
	toyota.getSpeed();
        // Turning the car
        direction = toyota.turn('l');
        
        if (direction == 1)
            cout << "Car is turning left \n";
        else
            cout << "Car is turning right \n";
        
        
	off = toyota.stop();
        
        if (off == false)
            toyota.getSpeed();
        else 
            toyota.getSpeed();
	
	system("pause");
	return  0;
}



