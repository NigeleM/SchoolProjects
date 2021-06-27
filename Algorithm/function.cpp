#include <iostream>
#include <cstdlib>

using namespace std;
int f(int x);
int main()
{
    int number,total;
    cout << "Enter the number of how many times : ";
    cin >> number;
    
        total = f(number);

    cout << "Total : " << total;
    return 0;
}

int f(int x)
{
    if (x == 0) return 2;
    else
        return x + f(x / 2);
}
