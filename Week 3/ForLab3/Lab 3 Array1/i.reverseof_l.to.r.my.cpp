#include <iostream>

using namespace std;

int main ()
{
        int n,l,r,t;
        cin>>n>>l>>r;
        int a[n];
        for (int i=1; i<=n; i++)
        {
                cin>>a[i];
        }
        
        for (int i=1; i<=r; i++) 
        {
                t=a[l];
                a[l]=a[r];
                a[r]=t;
        }

        for (int i = 1; i <= n; i++) 
        {
                cout << a[i] << " ";
        }
        
        return 0;
}