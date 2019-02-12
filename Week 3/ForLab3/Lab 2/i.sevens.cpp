#include <iostream>

using namespace std;

int main () 
{
  int n, sum=0;
  cin>>n;
  for (int i=0; i<n; i++)
  {
    int x;
    cin>>x;
    if (x%10==7)
      sum++;
  }
  cout<<sum;

  return 0;
}