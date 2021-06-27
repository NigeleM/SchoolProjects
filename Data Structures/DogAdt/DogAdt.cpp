


/* 
 * File:   DogAdt.cpp
 * Author: Nigele McCoy
 * Dr. Atluri CS215 
 * 
 * Implementation DogAdt Class
 * Created on February 21, 2019, 11:22 AM
 */

#include "DogAdt.h"

int DogAdt:: bark(string loudness )
{ 
    if(loudness == "high")
        return 1;
    else if(loudness == "low")
        return 2;
    else
        return 0;
} // Barking function

int DogAdt:: eat( string food)
{
    if(food == "dog food")
        return 1;
    else
        return 0;

} // eating function

int DogAdt:: play(string mood)
{
    if (mood ==  "happy")
        return 1;
    else
        return 0;
    
} // play
       
bool DogAdt:: setColor( string col)
{
    color = col;

    if(!color.empty())
        return true;
    else
        return false;
} // Set Color


bool DogAdt:: setBread(string brea)
{ 
    bread = brea;
    
    if(!bread.empty())
        return true;
    else
        return false;
    
} // Set color


bool DogAdt:: setAge( float ages)
{ 
    age = ages;
    
    if(age > 0)
        return true;
    else
        return false;
} // Set age


bool DogAdt:: setPetName( string name )
{ 
    petName = name;
    
     if(!petName.empty())
        return true;
    else
        return false;
} // Set PetName
   
string DogAdt:: getColor()
{ 
    return color;
} // Get Color


string DogAdt:: getBread()
{ 
    return bread;
} // Get Bread

float DogAdt:: getAge()
{ 
   return age;
} // Get Age

string DogAdt:: getPetName()
{ 
    return petName;
}

void DogAdt::displayDog()
{
  cout << "The color of the dog is " << color << endl; 
  cout << "The bread is " << bread << endl; 
  cout << "The age is " << age << endl; 
  cout << "The Pet Name " << petName << endl; 
  
}


DogAdt::DogAdt()
{

}

DogAdt::DogAdt(string col, string breads, float ages, string name)
{
  color = col;
  bread = breads;
  age = ages;
  petName = name;
  
}  // Constructor

