#include <iostream>
#include <cstdlib>

using namespace std;

typedef int Data;

int BinarySearch(Data A[], int P, int R, int V);

int main()
{
    Data* A;
    int N;
    cout << "Enter the number of data" << endl;
    cin >> N;
    A = new Data[N + 1];

    cout << "Enter Sorted data" << endl;
    for (int i = 1; i <= N; i++)
    {
        cout << "# " << i << ": ";
        cin >> A[i];
    }

    int search;
    cout << "Enter for value to search for : ";
    cin >> search;

    
    int found = BinarySearch(A, 1, N, search);
    cout << "Search value " << search << " found : " << found << endl;


    return 0;
}


int BinarySearch(Data A[], int P, int R, int V)
{
    if (P <= R)
    {
        int q = (P + R) / 2;
        if (V == A[q])
        {
            return q;
        }
        else if (V > A[q])
            return BinarySearch(A, q + 1, R, V);
        else
            return BinarySearch(A, q - 1, R, V);
    }
    else
        return -1;

}



