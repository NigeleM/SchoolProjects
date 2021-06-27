
/* 
 * File:   Car.h  
 * Author: nigele mccoy
 * DR. Atluri CIS 215
 * Car Program
 * Created on February 6, 2019, 4:18 PM
 */

#ifndef CAR_H
#define CAR_H
#include <string>

using namespace std;

class Car{
	private :
		
		int year,gas = 100,speed,acceleration;
		string color;
		string model;
		string make;
		double mileage;
	public :
		bool start();
                void accelerate(int a);
		void brake(int b); 
                int turn(char direction);
		bool stop(); 
                void getSpeed();
                
                
                		
};


#endif /* CAR_H */

