
/* 
 * File:   Shape.h
 * Author: Nigele McCoy
 * Dr.Atluri
 * Shape definition of shape Class for Shape Program
 * Created on February 12, 2019, 1:43 PM
 */


#include "Shape.h"
#include <cmath>

float Shape::getCircleArea()
{
    return area;
} // Returning area of Circle


float Shape:: getTriangleArea()
{
    return area; 
} // Returning area of Triangle


float Shape::getSquareArea()
{
    return area;
} // Returning area of Square

string Shape::getColor()
{
    return color;
} // Returning the color of the shape

float Shape:: getCircleCirCum()
{
    return circumference;
}
float Shape:: getSquarePeri()
{
    return perimeter;
}
float Shape:: getTrianglePeri()
{
    return perimeter;
}

void Shape:: setLength(float len)
{
    length = len;
} // Setting the length

void Shape:: setWidth(float wid)
{
    width = wid;
} // Setting the width

bool Shape:: setheight(float hei)
{
    height = hei;
    if (height > 0)
        return true;
    else
        return false;
} // Setting the height

bool Shape:: setColor(string col)
{
    color = col;
    if (color != "")
        return true;
    else
        return false;
    
} // Setting the color

void Shape:: setRadius (float rad)
{
    radius = rad;
} // Setting the Radius

void Shape:: calAreaCircle()
{
    area = pi * (radius * radius);
   
} // Calculating the area of a Circle;

void Shape:: calAreaTriangle()
{
    area = (height * width) / 2;
    
}// Calculating the area of a Triangle

void Shape:: calAreaSquare()
{
    area = length * width;
    

} // Calculating the area of a Square

void Shape:: calCirmCir()
{   
    circumference = 2 * pi * radius; 
    
} // Calculating the circumference of a Circle

void Shape:: calPeriTri()
{
    // Pythagorean Theorem
    // Getting the Hypotenuse 
    // Adding the height, width, hypotenuse
    perimeter = width + height + (sqrt(pow(height,2)+pow(width,2)));
    
} // Calculating the Perimeter of Triangle 

void Shape:: calPeriSquare()
{
    perimeter =  length * 4;
    
} // Calculating the Perimeter of Square 


void Shape:: displayCircle(float a, float c, string col)
{
    cout << "The area of the Circle is : " << a << endl;
    cout << "The circumference of the Circle is : " << c << endl;
    cout << "The color of the Circle is : " << col << endl;

} // Displaying Circle

void Shape:: displaySquare(float a, float c, string col)
{
    cout << "The area of the Square is : " << a<< endl;
    cout << "The perimeter of the Square : " << c << endl;
    cout << "The color of the Square is : " << col << endl;
} // Displaying Square       

void Shape:: displayTriangle(float a, float c, string col)
{
    cout << "The area of the Triangle is : " << a<< endl;
    cout << "The perimeter of the Triangle is : " << c << endl;
    cout << "The color of the Triangle is : " << col << endl;
    
} // Displaying Triangle 