#include<iostream>
#include<algorithm>

using namespace std;

int main()
{
    string s,t;
    cin >> s>>t;
    sort(s.begin(), s.end());
    sort(t.begin(), t.end());
    
    if (s==t)
        cout<<"YES";
    else
        cout<<"NO";

    return 0;
} 