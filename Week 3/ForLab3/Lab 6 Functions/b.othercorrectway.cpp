#include <iostream>
#include <cmath>

using namespace std;

int d[500500];
void Difference(int n, int a[], int b[]) 
{
  for (int i=1; i<=n; i++)
  {
    d[i]=a[i]-b[i];
  }
}

int main ()
{
    int n;
    cin>>n;
    int a[n+1], b[n+1];

    for (int i=1; i<=n; i++)
    {
        cin>>a[i];
    }
    for (int i=1; i<=n; i++)
    {
        cin>>b[i]; 
    }

    Difference(n, a, b);
    for (int i=1; i<=n; i++)
    {
        cout <<abs(d[i]) << ' '; //abs-module
    }

    return 0;
}
