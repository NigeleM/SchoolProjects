

/* 
 * File:   DogAdtMain.cpp
 * Author: Nigele McCoy
 * Dr. Atluri CS215 
 * 
 * Testing DogAdt Class
 * Created on February 21, 2019, 11:22 AM
 */

#include <cstdlib>
#include "DogAdt.h"

using namespace std;

/*
 * 
 */
int main(int argc, char** argv) {

    
    
    DogAdt *Pitbull = new DogAdt("Grey","Pit Bull",5,"Danger");
    
    if(Pitbull->bark("high") == 1)
        cout << "Dog is barking loud \n";
    else
        cout << "Dog is barking low \n";
    
    if(Pitbull->eat("dog food") == 1)
        cout << "Dog is eating \n";
    else
        cout << "Dog is not eating \n";
    
    
    if(Pitbull->play("happy") == 1)
        cout << "Dog is happily playing \n\n";
    else
        cout << "Dog is not happy and unwilling to play \n\n";
    
    Pitbull->displayDog();
    
    
    
    
    
    
    return 0;
}

