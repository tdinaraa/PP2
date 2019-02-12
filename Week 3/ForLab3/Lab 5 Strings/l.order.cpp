#include <iostream>

using namespace std;

int main()
{
	string s;
	cin >> s;
	//abcc
	for(int i = 0; i < s.size() - 1; i++) //-1 becuse s[i] sravnivaetsya s [i+1]
	{
		if(s[i] > s[i+1])
		{
			cout << "NO";
			exit(0);
		}
	}
	cout << "YES";
	
    return 0;
}
