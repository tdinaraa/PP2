#include<iostream>
#include <string>

using namespace std;

int main()
{
	string s;
	cin>>s;

	s.append (1, s[0]);
	for(int i = 0; i < (s.size()/2); i++) //arbbra
	{
		if(s[i] != s[s.size() - 1 - i])
		{
			cout << "NO";
			exit(0);
		}
		
	}
	cout << "YES";
}
