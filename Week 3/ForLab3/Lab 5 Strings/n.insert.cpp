#include<iostream>
#include<algorithm>

using namespace std;

int main()
{
    string s = "Welcome ";
    string s2;
    cin>>s2;
    s.insert(8,s2);

    cout << s<< endl;

    return 0;
}