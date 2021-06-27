#include <cstdlib>
#include <iostream>


using namespace std;

/*
 *
 */

typedef int Data;

void quickSort(Data A[], int p, int r);
int partition(Data A[], int p, int r);

int main()
{
    Data* A;
    int N;
    cout << "Enter the number of data" << endl;
    cin >> N;
    A = new Data[N + 1];

    cout << "Enter Unsorted data" << endl;
    for (int i = 1; i <= N; i++)
    {
        cout << "# " << i << ": ";
        cin >> A[i];
    }

    quickSort(A, 1, N);


    for (int count = 1; count <= N; count++)
    {
        cout << A[count] << " ";
    }
    cout << endl;
    return 0;

	system("pause");
}


void quickSort(Data A[], int p, int r)
{
    int q;
    if (p < r)
    {
        q = partition(A, p, r);
        quickSort(A, p, q - 1);
        quickSort(A, q + 1, r);
    }


}

int partition(Data A[], int p, int r)
{
    Data x = A[r];
    int i = p - 1;
    int j = 0;
    for (j = p; j <= r - 1; j++)
    {
        if (A[j] <= x)
        {
            i += 1;
            swap(A[i], A[j]);
        }
    }
    swap(A[i + 1], A[r]);
    return i + 1;
}