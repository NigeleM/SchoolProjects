#include <cstdlib>
#include <iostream>
#include <climits>
using namespace std;

/*
 *
 */

typedef int Data;

void mergeSort(Data A[], int p, int r);
void merge(Data A[], int p, int q, int r);

int main(int argc, char** argv) {

    
    Data *A;
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
   
    mergeSort(A, 1, N);


   for (int count = 1; count <= N; count++)
   {
       cout << A[count] << " ";
   }
   cout << endl;
    return 0;
}

void mergeSort(Data A[], int p, int r)
{
    int q;
    if (p < r)
    {
        int q = (p + r) / 2;
        mergeSort(A, p, q);
        mergeSort(A, q+1, r);
        merge(A, p, q, r);
    }

}

void merge(Data A[], int p, int q, int r)
{
    Data *left;
    Data *right;
    int n1, n2;
    int i = 0;
    int j = 0;
    int k = 0;
    n1 = q - p + 1;
    n2 = r - q;
    left = new Data[n1+2];
    right = new Data[n2+2];
    // Left array and Right array be new
    for (int i = 1; i <= n1; i++)
    {
        left[i] = A[p + i - 1];
    }

    for (int j = 1; j <= n2; j++)
    {
        right[j] = A[q + j];
    }

    left[n1 + 1] = INT_MAX;
    right[n2 + 1] = INT_MAX;
    i = 1;
    j = 1;

    for (k = p; k <= r; k++)
    {
        if (left[i] <= right[j])
        {
            A[k] = left[i];
            i++;
        }
        else
        {
            A[k] = right[j];
            j++;
        }
    }

}
