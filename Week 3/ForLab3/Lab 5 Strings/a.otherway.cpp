#include <iostream>

using namespace std;

int main() 
{
  string s;
  int sum1=0,sum2=0;
  cin>>s;
  
  for (int i = 0; i <s.length(); i++) 
  {
      if (65<=s[i] && s[i]<=90)
      { //'A'=s && 'A'=s
        sum1++; 
      }
  else
      if (97<=s[i] && s[i]<=122)
      {
        sum2++;
      }
  }
  cout<<sum2<<" "<<sum1;

  return 0;
}


	


