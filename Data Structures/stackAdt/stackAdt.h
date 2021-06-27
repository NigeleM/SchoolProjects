/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/* 
 * File:   stackAdt.h
 * Author: Nigele McCoy
 * Dr. Atluri CS215 
 * 
 *  StackAdt - stack
 * Created on March 31, 2019, 1:45 PM
 */

#include <string>

using namespace std;

#ifndef STACKADT_H
#define STACKADT_H


class stackAdt{

    private:
        // full length of the stack
      int length = 0;
      // current size of the stack
      int momentLength =-1;
      string *array;
    public:
        // Constructor
        stackAdt(int size);
        // Destructor
        ~stackAdt();
        // Stack methods
        bool isEmpty();
        bool isFull();
        bool push(string word);
        bool pop();
        // stack Additonal files;
        bool write(string fileName);
        bool read(string fileName);
        string popTop();
        

};

// Calculate the size of the stack
int calculateNumRecords(string nameofFile);

#endif /* STACKADT_H */

