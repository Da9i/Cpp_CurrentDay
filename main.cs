#include <iostream>
using namespace std;
void currentday(int& d, int& m, int& y)
{
	cout << "ENTER THE DATE:" << endl;
	cin >> d >> m >> y;
	if (d > 0 && d < 31)
	{
		if (m > 0 && m <= 12)
		{
			if (y > 999 && y <= 2019)
			{
				cout << "DATE : " << d << "-" << m << "-" << y << endl;
			}
		}

	}
}
void difference(int& a, int& b, int& c)
{
	int temp = 0, days = 0;
	currentday(a, b, c);

	if (c%4==0 && c%100!=0)
	{
		cout << "IT IS A LEAP YEAR :" << endl;
		temp = ((b * 30)+1)+a;
		days = temp;
		cout << "CURRENT DAY OF THE YEAR IS :" << days;
	}
	else if (c % 100 == 0 && c % 400 == 0)
	{
		cout << "IT IS A LEAP YEAR :" << endl;
		temp = ((b * 30) + 1)+a;
		days = temp;
		cout << "CURRENT DAY OF THE YEAR IS :" << days;
	}
	else
	{
		temp = ((b - 1) * 30)+a;
		days = temp;
		cout << "CURRENT DAY OF THE YEAR IS :" << days;
	}
}
int main()
{
	int d, m, y;
	difference(d, m, y);
	system("pause>0");
}
