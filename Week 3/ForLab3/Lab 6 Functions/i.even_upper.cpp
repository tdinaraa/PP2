#include <iostream>

using namespace std;

string toUpper(string s)  // takes one parametr English character
{
    int c;
    for (int i=0; i<s.size(); i++)
    {
        if (i%2==0 && 'a'<=s[i] && s[i]<='z')
        {
            s[i]=s[i]-'a'+'A'; //zamena malenkoi bukvy na bolwuyu
        }
    }
    return s;
}

int main () 
{
    string s;
    cin >> s;
    cout<<toUpper(s);
    
    return 0;
}
