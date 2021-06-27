
/* 
 * File:   studentGradeMain.cpp
 * Author: Nigele McCoy
 * DR. Atluir
 * Student Grade Main
 * Created on February 19, 2019, 1:23 PM
 */

#include <cstdlib>
#include <iostream>
#include "studentGrade.h"

using namespace std;

/*
 * 
 */
int main(int argc, char** argv) {

    int recordNum;
    string fileName;
    
    cout << "Enter the file name you would like to read: ";
    cin >> fileName;
    
    // Getting the Record count
    recordNum = calculateNumRecords(fileName);
    // Creating an array of objects
    studentGrade students[recordNum];
    
     // Setting Each object file name to file to be read
    for(int count = 0; count < recordNum; count++)
         students[count].fileName = fileName;
    
    // Setting Each record to a student object  
    for(int count = 0; count < recordNum; count++)
        students[count].setRecords(count);
    
    // Display the student Records in Table form
    cout << "\nFirst Name \t" << "Last Name \t" << "Test 1 \t" 
        << "Test 2 \t" << "Test 3 \t" << "Total \t" << "Average " << "Grade "<< endl;
    cout << "----------------------------------------------------------------------------------\n";
    for(int count = 0; count < recordNum; count++)
        students[count].displayRecords();
    cout << "----------------------------------------------------------------------------------\n";
    
    
    return 0;
}

