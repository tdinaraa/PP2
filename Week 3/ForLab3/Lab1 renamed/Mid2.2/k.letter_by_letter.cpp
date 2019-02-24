#include<iostream>

using namespace std;

int main()
{
    string s;
    cin>>s;
    int n=1;
    while (n<=s.size())
    {
        for (int i=0;i<n;i++)
        {
            cout<<s[i];
        }
        n++;
        cout<<endl;
    }
}