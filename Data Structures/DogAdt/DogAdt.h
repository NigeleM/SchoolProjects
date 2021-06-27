

/* 
 * File:   DogAdt.h
 * Author: Nigele McCoy
 * Dr. Atluri CS215 
 * 
 * DogAdt Class
 * Created on February 21, 2019, 11:22 AM
 */


#include <iostream>
#include <string>

using namespace std;

#ifndef DOG_H
#define DOG_H

class DogAdt {
    
    private:
        string color;
        string bread;
        float age;
        string petName;
    
    public:
        int bark(string loudness );
        int eat( string food);
        int play(string mood);
        // Setters
        bool setColor(string col);
        bool setBread(string brea);
        bool setAge(float ages);
        bool setPetName(string name);
        // Getters
        string getColor();
        string getBread();
        float getAge();
        string getPetName();
        
        // Display Dog
        void displayDog();
        
        
        DogAdt();
        DogAdt(string col, string breads, float ages, string name);
       

};



#endif /* DOG_H */

