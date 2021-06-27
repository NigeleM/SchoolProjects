
/* 
 * File:   ShapeMain.cpp
 * Author: Nigele McCoy
 * Dr.Atluri
 * Created on February 12, 2019, 1:42 PM
 */

#include <cstdlib>
#include "Shape.h"

using namespace std;

/*
 * 
 */
int main(int argc, char** argv) {

    Shape circle,square,triangle;
    float radius,length,width,height;
    string color;
   
    // Using Circle & Circle Methods
    cout << "Enter the radius for the Circle : ";
    cin >> radius;
    circle.setRadius(radius);
    circle.calAreaCircle();
    circle.calCirmCir();
    cout << "Enter the color for the Circle : ";
    cin >> color;
    if(circle.setColor(color) == true)
        cout << "\n The color of Circle now is " << color << "\n\n";
    else 
        cout << "\n The color has not changed \n\n";
    circle.displayCircle(circle.getCircleArea(),circle.getCircleCirCum(),circle.getColor());
    
    // Using Square & Square Method
    cout << "Enter the length for the square : ";
    cin >> length;
    square.setLength(length);
    square.setWidth(length);
    square.calAreaSquare();
    square.calPeriSquare();
    color = "";
    cout << "Enter the color for the Square : ";
    cin >> color;
    
    if(square.setColor(color) == true)
        cout << "\n The color of Square now is " << color << "\n\n"; 
    else 
        cout << "\n The color has not changed \n\n";
    square.displaySquare(square.getSquareArea(),square.getSquarePeri(),square.getColor());
    
    // Using Triangle & Triangle Method
    cout << "Enter the width for the Triangle : ";
    cin >> width;
    triangle.setWidth(width);
    cout << "Enter the height for the Triangle : ";
    cin >> height;
    if (triangle.setheight(height) == true)
        cout << "\n The height has changed \n\n";
    else
        cout << "\n The height is not a valid height \n\n";
    triangle.calAreaTriangle();
    triangle.calPeriTri();
    color = "";
    cout << "Enter the color for the Triangle : ";
    cin >> color;
    if(triangle.setColor(color) == true)
        cout << "\n The color of Triangle now is " << color << "\n\n";
    else 
        cout << "\n The color has not changed \n\n";
    triangle.displayTriangle(triangle.getTriangleArea(),triangle.getTrianglePeri(),triangle.getColor());
     
    return 0;
}

