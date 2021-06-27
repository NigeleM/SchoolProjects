/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/* 
 * File:   main.cpp
 * Author: nigele
 *
 * Created on March 31, 2019, 1:44 PM
 */

#include <cstdlib>
#include "stackAdt.h"
#include <iostream>
using namespace std;

/*
 * 
 */
int main(int argc, char** argv) {
  
    int number;
    number = calculateNumRecords("stackInput.txt");
    stackAdt wordStack(number);
    // Read data into stack
    if (wordStack.read("stackInput.txt"))
        cout << "Data read into stack \n";
    else
        cout << "Data wasn't able to be read \n";
    // data from stack written to file
    if (wordStack.write("stackOutput.txt"))
        cout << "Data written to file \n";
    else
        cout << "Data wasn't able to be written \n";
   
       
    return 0;
}

