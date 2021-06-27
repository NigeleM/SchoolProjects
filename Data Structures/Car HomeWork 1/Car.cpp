/* 
 * File:   Car.cpp
 * Author: nigele mccoy
 * DR. Atluri CIS 215
 * Car Program 
 * Created on February 6, 2019, 4:18 PM
 */


#include <iostream>
#include "Car.h"

bool Car::start()
{
	if (gas > 0)
		return true;
	else
		return false;
        
} // Determining if car is on or off

void Car::accelerate(int a)
{
	speed += a;

} //  Accelerating the car by a

void Car::brake(int b)
{
	speed -= b;
	
} // Decelerating the car by b

int Car::turn(char direction)
{	
	if (direction == 'L' || direction == 'l')
		return 1;
	else if(direction == 'R' || direction == 'r')
		return 2;
	else
		cout << "Invalid direction car will not turn";
} // Turning function 

bool Car::stop()
{
	if (speed == 0)
        {
            cout << "Car is stationary \n";
            return true;
        }
		
	else{
		speed = 0;
		return true;
	}
} // SToping the car speed

void Car::getSpeed()
{

	cout << "The speed now is " << speed << endl;

}
