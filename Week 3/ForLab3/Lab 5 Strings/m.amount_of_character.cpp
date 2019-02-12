#include <iostream>

using namespace std;

int main()
{
    string s;
    char x;
    int num,sum=0;
    cin >> s>>x>>num;
    for (int i=0; i<s.size(); i++)
    {
        if (s[i]==x)
        sum++;
    }
    
    if (sum==num)
        cout<<"YES";
    else 
        cout<<"NO";

    return 0;
}