#include <iostream>

using namespace std;

int Euclid(int a, int b);

int main()
{
	int num, num2, gcd;
	cout << "GCD Program \n";
	cout << "Enter the first number : ";
	cin >> num;
	cout << "Enter the second number : ";
	cin >> num2;

	while (num < num2)
	{
		cout << "First number must be greater than the second \n";
		cout << "Enter the first number : ";
		cin >> num;
		cout << "Enter the second number : ";
		cin >> num2;
	}

	gcd = Euclid(num, num2);

	cout << "The GCD of " << num << " and " << num2 << " is " << gcd << endl;

	return 0;
}

int Euclid(int a, int b)
{
	if (b == 0)
		return a;
	else
	{
		return Euclid(b, a % b);
	}
}

