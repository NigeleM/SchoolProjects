
/* 
 * File:   studentGradeMain.cpp
 * Author: Nigele McCoy
 * DR. Atluir
 * Student Grade Class header file
 * Created on February 19, 2019, 1:23 PM
 */

#ifndef STUDENTGRADE_H
#define STUDENTGRADE_H

#include <string>
using namespace std;


class studentGrade{
    
    private:
        
        struct {
            string firstName;
            string lastName;
            char letter;
            float test1;
            float test2;
            float test3;
            float average;
            float total;    
        };
        
    public:
        
       
        string fileName;
        // Setters
        void setfileName(string file);
        void setRecords(int numRecords);
        // Helper Methods
        void displayRecords();
        int calculateAverage();
        int calculateTotal();
        char calculateLetter(); 
        
};

int calculateNumRecords(string nameofFile);


#endif /* STUDENTGRADE_H */

