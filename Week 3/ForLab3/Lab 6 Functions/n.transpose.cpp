#include <iostream>

using namespace std;

int n, m, a[1000][1000];

void transpose(int n, int m) 
{
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
        {
            cout<<a[j][i]<<" ";
        }
    cout<<endl;
    }
}

int main() 
{
    cin >> n >> m;
    for (int i = 0; i < n; i++) 
    {
        for (int j = 0; j < m; j++) 
        {
            cin>>a[i][j];
        }
    }
    transpose(n, m);

    return 0;
}
