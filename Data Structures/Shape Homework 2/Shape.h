
/* 
 * File:   Shape.h
 * Author: Nigele McCoy
 * Dr.Atluri
 * Shape Class for Shape Program
 * Created on February 12, 2019, 1:43 PM
 */

#include <string> 
#include <iostream>

using namespace std;

#ifndef SHAPE_H
#define SHAPE_H

class Shape{
    
    private:
        // Variables 
        float length,width,height,area,
                radius,circumference,
                perimeter;
        float const pi = 3.14;
        string color;
        
    public:
        // Getters 
        float getCircleArea();
        float getTriangleArea();
        float getSquareArea();
        float getCircleCirCum();
        float getSquarePeri();
        float getTrianglePeri();
        string getColor();
        
        // Setters 
        void setLength(float len);
        void setWidth(float wid);
        bool setheight(float hei);
        bool setColor(string col);
        void setRadius (float rad);
        
        // Helper Methods
        // Calculating the Area or Perimeter or circumference
        void calAreaCircle();
        void calAreaTriangle();
        void calAreaSquare();
        void calCirmCir();
        void calPeriTri();
        void calPeriSquare();
        // display methods for shapes
        void displayCircle(float a, float c, string col);
        void displaySquare(float a, float c, string col);
        void displayTriangle(float a, float c, string col);
        
        
};

#endif /* SHAPE_H */

