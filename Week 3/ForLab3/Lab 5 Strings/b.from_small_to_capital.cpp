#include<iostream>

using namespace std;

int main()
{
    string s;
    cin>>s;
    for (int i=0; i<s.length(); i++) 
    {
        if ('a'<=s[i] && s[i]<='z')
        {
            s[i]=s[i]-32;
        }
    }
    cout<<s;

    return 0;
}


