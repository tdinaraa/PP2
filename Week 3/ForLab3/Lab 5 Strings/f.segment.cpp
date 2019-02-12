#include<iostream>

using namespace std;

int main()
{
    string s;
    int l,r;
    cin>>s>>l>>r;

    string k = s.substr (l,r-l+1); //elsee tolko starts from 0, it has r+1; in other cases r-l+1
    cout<<k;

    return 0;
}