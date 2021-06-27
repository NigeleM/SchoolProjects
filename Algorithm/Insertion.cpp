
#include <iostream>
#include <cstdlib>

using namespace std;

void insertionSort(int A[],int l);

int main()
{
    int length = 10;
    int B[] = { 1,2,4,7,8,9,0,3,5,6 };
    insertionSort(B,length);

    for (int count = 0; count < length; count++)
    {
        cout << B[count] << " ";
    }
    

   // return 0;
}

void insertionSort(int A[],int l)
{
    int key,j;
    for (int count = 0; count < l; count++)
    {
        key = A[count];
        j = count - 1;
        while (j >= 0 && A[j] > key)
        {
            A[j + 1] = A[j];
            --j;
        }
        A[j + 1] = key;
    }

}
