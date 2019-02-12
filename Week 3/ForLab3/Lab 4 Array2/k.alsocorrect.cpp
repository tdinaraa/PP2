#include <iostream>

using namespace std;

int main()
{
    int n, m,sum=0,sum2=0;
    cin >> n >> m;
    int a[n][m];
    for(int i = 0; i < n; i++)
    {
        for(int j =0; j < m; j++)
        {
            cin >> a[i][j];
        }
    }
    for(int i = 0; i < n; i++) 
    {
        for(int j = 0 ; j < m; j++)
        {
            sum=sum+a[i][j];
        }
    cout<<"\nThe sum of row number "<<i+1<<" is "<<sum<<" ";
    sum=0;
    }

    for(int i= 0 ; i < m; i++)
    { //column
        for(int j = 0 ; j < n; j++) //row
        {
            sum2=sum2+a[j][i];
        }
    cout<<"\nThe sum of column number "<<i+1<<" is "<<sum2<<" ";
    sum2=0;
    }

    return 0;
}