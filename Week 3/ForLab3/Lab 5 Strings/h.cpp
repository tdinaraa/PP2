#include <iostream>

using namespace std;

int main()
{
	// 333 22 322 
	string s;
	cin >> s;
	int arr[9];
	for(int i = 0; i < 9; i++)
	{
		arr[i] = 0;
	}
	for(int i = 0; i < s.size(); i++)
	{
		arr[ (s[i] - '0') - 1 ]++;
	}
	for(int i = 0; i < 9; i++)
	{
		if(arr[(s[0] - '0') - 1] != arr[i] && arr[i] != 0)
		{
			cout << "NO";
			exit(0);
		}
	}
	cout << "YES";
	
	return 0;
}