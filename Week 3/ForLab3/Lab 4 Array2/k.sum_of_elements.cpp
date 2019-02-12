#include <iostream>

using namespace std;

int main()
{
    int n, m,i, j;
    cin >> n >> m;
    int a[n][m];
    int r[n],c[m];
    for(i = 0; i < n; i++)
    {
        for(j = 0 ; j < m; j++)
        {
          cin >> a[i][j];
        }
    }
    for ( i=0; i<n; i++)
    {
      r[i]=0;
      for ( j=0; j<m; j++)
      r[i]+=a[i][j];
    }
    for ( j=0; j<m; j++)
    {
      c[j]=0;
      for ( i=0; i<n; i++)
      c[j]+=a[i][j];
    }
    for ( i=0; i<n; i++)
      cout<<"\nThe sum of row number "<<i+1<<" is "<<r[i];
    for ( j=0; j<m; j++)
      cout<<"\nThe sum of column number "<<j+1<<" is "<<c[j];

    return 0;
}
