#include <iostream>

using namespace std;

int main ()
{
    int n, maxind=0;
    cin>>n;
    int a[n];
    for (int i = 0; i<n; i++)
    {
        cin >> a[i];
        if (a[i]>a[maxind])
        {
            maxind=i;
        }
    }
    cout<<maxind+1;
    
    return 0;
}