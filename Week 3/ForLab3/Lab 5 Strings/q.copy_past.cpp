#include <iostream>

using namespace std;

int main()
{
	string s,t;
	cin >> s >> t;
	string obw;
    //wa wawawawa
    //wa wawawaw
	int a = t.size(); //8 //7
	int b = s.size(); //2 //2
	for(int i = 0; i < a / b; i++) //i do 4 //i do 3
	{
		obw+= s; //obw=wawawa	
	}
	if(obw == t)
		cout << "YES";
	else
		cout << "NO";	
}