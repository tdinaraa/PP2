#include <iostream>
using namespace std;

int main() 
{
    string s;
    int sum1=0,sum2=0;
    cin>>s;
    for (int i = 0; i <s.length(); i++) 
    {
        if ('A'<=s[i] && s[i]<='Z')
        { 
          sum1++; 
        }
    else
        if ('a'<=s[i] && s[i]<='z')
        {
          sum2++;
        }
    }
    cout<<sum2<<" "<<sum1;
    
    return 0;
  
}