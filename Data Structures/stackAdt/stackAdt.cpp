/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

#include "stackAdt.h"
#include <iostream>
#include <fstream>


int calculateNumRecords(string nameofFile)
{
    // This function will be used to
    // Calculate number of records
    // This function is used 
    
    ifstream file;
    int wordCount =0;
    string word;
    
    
    file.open(nameofFile);
    // Open file
    if (file){
        
        while(!file.eof())
        {
           file >> word;
            
           if (word.length() > 0)
           {
               // Getting the number of records
               wordCount++;   
           }
           else
               continue;
        } 
    }
    else
        cout << "File " << nameofFile << " not found "<< endl;

    file.close();
    // Returning the number of records
    return wordCount;
}


bool stackAdt::isEmpty()
{
    if (momentLength == 0)
        return true;
    else            
        return false;
} // Checking to see if stack is empty

bool stackAdt::isFull()
{
    if (length == momentLength)
        return true;
    else            
        return false;
} // Checking to see if stack is full

bool stackAdt::push(string word)
{
    if(isFull())
    {
        cout << "The stack is Full \n";
        return false; 
    }
    else
    {
        momentLength++;
        array[momentLength] = word;
        return true; 
    }
        
} // adding to list


bool stackAdt::pop()
{
    if(isEmpty())
    {
        cout << "The stack is empty \n";
        return false;
    }
    else
    {
        array[momentLength] = "";
        momentLength--;
        return false;
    }
} // deleting last element in stack

string stackAdt::popTop()
{
    return array[momentLength];
} // Return last element 

bool stackAdt::write(string fileName)
{
    ofstream file;
    file.open(fileName);
    int count = 0;
    for(count = length; count > 0; count--)
    {  file << array[count] << " ";}    
    file.close();
 
    if (count < 0)
        return false;
    else
        return true;
} // write stack to the file
     
bool stackAdt::read(string fileName)
{
    ifstream file;
    int wordCount = 0;
    bool isRead;
    string word;
    
    
    file.open(fileName);
    // Open file
    if (file){
        isRead = true;
        while(!file.eof())
        {
           file >> word;
            
           if (word.length() > 0)
           {
               array[wordCount] = word;
               wordCount++;
               momentLength++;
           }
           else
               continue;
        } 
    }
    else 
        isRead = false;
    
    file.close();
    // Returning the number of records
    return isRead;

} // Read file 


stackAdt::stackAdt(int size)
{
    length = size;
    array = new string[size];
} // constructor  


stackAdt::~stackAdt()
{
    delete [] array;
} // delete stack