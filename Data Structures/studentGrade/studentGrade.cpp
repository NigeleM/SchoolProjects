/* 
 * File:   studentGrade.cpp
 * Author: Nigele McCoy
 * DR. Atluir
 * Student Grade Implementation
 * Created on February 19, 2019, 1:23 PM
 */


#include "studentGrade.h"
#include <fstream>
#include <iostream>

int calculateNumRecords(string nameofFile)
{
    // This function will be used to
    // Calculate number of records
    // This function is used 
    
    ifstream file;
    int studentNum =0;
    string lastName,name,newName;
    float test1,test2,test3;
    
    file.open(nameofFile);
    // Open file
    if (file){
        
        while(!file.eof())
        {
           file >> name >> lastName >>  test1 >> test2 >> test3;
            
           if (name.length() > 0 && name != newName)
           {
               // Getting the number of records
               newName = name;
               studentNum++;   
           }
           else
               continue;
        } 
    }
    else
        cout << "File " << nameofFile << " not found "<< endl;

    file.close();
    // Returning the number of records
    return studentNum;
}

void studentGrade:: setRecords(int numRecords)
{
  ifstream file;
  string firstNames,lastNames;
  float test11,test21,test31;
  int counter = 0;
  numRecords += 1;
  
  // NumRecords variable is used to get the corresponding record 
  // for the studentGrade Object in the Array of Objects 
 
  file.open(fileName);
    
    if (file){
         
        while(!file.eof())
        {
           file >> firstNames >> lastNames >>  test11 >> test21 >> test31;
            
           if (firstNames.length() > 0  && numRecords != counter)
           {  
                firstName = firstNames;
                lastName  = lastNames;
                test1 = test11;
                test2 = test21;
                test3 = test31; 
                counter++;     
           }
           else
               continue;
        }     
    }
    else
        cout << "File " << fileName  << " not found "<< endl;

    file.close();
} // Set Records


void studentGrade::displayRecords()
{
   
   cout << firstName << "\t\t" << lastName << "\t\t" << " " <<test1 << "\t" << test2 << "\t" << test3 
        << "\t" <<  calculateTotal() << "\t" << calculateAverage() << "\t" << calculateLetter() << endl; 
} // Displaying The records

void studentGrade:: setfileName(string file)
{
    
    fileName = file;
} // Setting the file name that the structure is working on 

int studentGrade:: calculateAverage()
{
    average = (test1 + test2 + test3) / 3;
    return average;
} // Calculating the Average


int studentGrade:: calculateTotal()
{
    total = test1 + test2 + test3;
    return total;
} // Calculating the Total;

char studentGrade:: calculateLetter()
{
    if (average <= 59)
        letter = 'F';
    else if (average <= 69)
        letter = 'D';
    else if (average <= 79)
        letter = 'C';
    else if (average <= 89)
        letter = 'B';
    else
        letter = 'A';

    return letter;
} // Calculating Letter Grade