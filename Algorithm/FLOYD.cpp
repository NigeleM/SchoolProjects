// Example program
#include <iostream>
#include <string>
using namespace std;

void Floyd(int** A, int** D, int** P, int N)
{
    int i, j;
    for (i = 1; i <= N; i++)
    {
        for (j = 1; j <= N; j++)
        {
            D[i][j] = A[i][j];
            P[i][j] = 0;
        }
    }


    int k;
    int Dnew;
    for (k = 1; k <= N; k++)
    {
        for (i = 1; i <= N; i++)
        {
            for (j = 1; j <= N; j++)
            {
                Dnew = D[i][k] + D[k][j];
                if (Dnew < D[i][j])
                {
                    D[i][j] = Dnew;
                    P[i][j] = k;
                }
            }
        }
    }
}




int main()
{
    int** A, ** D, ** P;
    int N;
    cout << "N = ";
    cin >> N;

    A = new int* [N + 1];
    D = new int* [N + 1];
    P = new int* [N + 1];
    int i, j;
    for (i = 1; i <= N; i++)
    {
        A[i] = new int[N + 1];
        D[i] = new int[N + 1];
        P[i] = new int[N + 1];
    }

    cout << "Enter the adjacency matrix A row by row" << endl;
    for (i = 1; i <= N; i++)
        for (j = 1; j <= N; j++)
            cin >> A[i][j];

    Floyd(A, D, P, N);
    cout << "The Distance matrix " << endl;

    for (i = 1; i <= N; i++)
    {
        for (j = 1; j <= N; j++)
            cout << D[i][j] << ", ";
        cout << endl;
    }

    cout << "The P matrix " << endl;
    for (i = 1; i <= N; i++)
    {
        for (j = 1; j <= N; j++)
            cout << P[i][j] << ", ";
        cout << endl;
    }

}
