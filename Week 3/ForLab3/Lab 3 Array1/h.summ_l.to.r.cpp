#include <iostream>

using namespace std;

int main () 
{
    int n,l,r;
    long long sum=0;
    cin>>n>>l>>r;
    int a[n];
    
    for (int i=1; i<=n; i++)
    {
        cin>>a[i];
    }
    
    for (int i=l; i<=r; i++) 
    {
        sum=sum+a[i];
    }
    cout<<sum;

    return 0;
}