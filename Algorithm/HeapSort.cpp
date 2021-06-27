#include <cstdlib>
#include <iostream>


using namespace std;

/* 
 * HeapSort Algorithm 
 * Nigele McCoy
 * Dr. Alak 
 */

typedef int Data;

void BuildMaxHeap(Data A[], int N);
void MaxHeapify(Data A[], int N, int i);
void HeapSort(Data A[], int N);
void Insert(Data A[], int N, int V);
void UpHeap(Data A[], int i);
void Delete(Data A[], int N, int V);





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
    int i = N / 2;

    BuildMaxHeap(A, N);
    cout << "Build Max Heap \n";
    for (int count = 1; count <= N; count++)
    {

        cout << A[count] << " ";
    }
    cout << endl;
    
    MaxHeapify(A, N, i);
    HeapSort(A, N);
    cout << "Sorted \n";
    for (int count = 1; count <= N; count++)
    {
        cout << A[count] << " ";
    }
    cout << endl;

    Insert(A, N, 10);
    cout << "Inserted \n";
    for (int count = 1; count <= N+1; count++)
    {
        cout << A[count] << " ";
    }
    cout << endl;

    Delete(A, N, 4);
    cout << "Deleted \n";
    for (int count = 1; count <= N; count++)
    {
        cout << A[count] << " ";
    }
    cout << endl;
    system("pause");

    return 0;
}

void MaxHeapify(Data A[], int N, int i)
{
    int L = 2 * i;
    int R = L + 1;
    int Largest;
    if (L <= N)
    {
        Largest = L;

        if (L < N)
        {
            R = L + 1;
            if (A[R] >= A[Largest])
                Largest = R;

        }

        if (A[Largest] > A[i])
        {
            swap(A[Largest], A[i]);
            MaxHeapify(A, N, Largest);
        }
    }
}

void BuildMaxHeap(Data A[], int N)
{
    for(int I = N / 2; I < 1; I--)
        MaxHeapify(A, N, I);
}

void HeapSort(Data A[], int N)
{
    int heapsize = N;
    while (heapsize > 1)
    {
        swap(A[1], A[heapsize]);
        heapsize = heapsize - 1;
            MaxHeapify(A, heapsize, 1);
    }
}

void Insert(Data A[], int N, int V)
{
    N = N + 1;
    A[N] = V;
    UpHeap(A, N);

}

void Delete(Data A[], int N, int V)
{
    if (V > 1)
    {
        int p = V / 2;
        if (A[V] > A[p])
        {
            swap(A[V], A[p]);
            UpHeap(A, N-1);
        }
    }

}


void UpHeap(Data A[], int i)
{
    if (i > 1)
    {
        int p = i / 2;
        if (A[i] > A[p])
        {
            swap(A[i], A[p]);
            UpHeap(A,p);
        }
    }
}