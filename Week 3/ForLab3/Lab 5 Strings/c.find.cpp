#include<iostream>
#include<algorithm>
#include <string>

using namespace std;

int main()
{
    string s;
    string t;
    cin>>s>>t;
    size_t res = s.find(t); 

    if(res == string::npos) //no matches
        cout << "NO";
    else
        cout << "YES";
        
    return 0;
}