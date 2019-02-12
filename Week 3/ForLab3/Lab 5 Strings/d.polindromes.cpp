#include <iostream>
#include<algorithm>
#include <string>

using namespace std;

int main()
{
	string s;
	cin >> s;
	// aba
	for(int i = 0; i < (s.size()/2); i++)
	{
		if(s[i] != s[s.size() - 1 - i])
		{
			cout << "NO";
			exit(0);
		}	
	}
	cout << "YES";
}