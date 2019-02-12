#include <iostream>

using namespace std;

int main()
{
	int n,num=0;
	cin >> n;
	int arr[n+1][n+1];

	for(int i = 0; i <n; i++) 
	{
		arr[0][i] = num;
		arr[i][0]=num;
		num++;
		for(int i = 1; i < n; i++)
		{
			for(int j = 1; j < n; j++)
			{
				arr[i][j] = arr[0][j]*arr[i][0];
			}
		}
	}
	for(int i = 0; i < n; i++) 
	{
		for(int j = 0 ; j < n; j++)
		{
			cout << arr[i][j] << " ";
		}
		cout << endl;
	}
	return 0;
}
