#include<iostream>
#include<algorithm>

using namespace std;

int main()
{
    string s;
    char max=s[0];
    cin>>s;
    for (int i=1; i<s.size(); i++)
    {
        if (s[i]>max)
        {
            max=s[i];
        }
    }
    cout << max<< endl;

    return 0;
}