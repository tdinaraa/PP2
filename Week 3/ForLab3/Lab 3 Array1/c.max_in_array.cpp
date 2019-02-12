#include <iostream>

using namespace std;

int main ()
{
    int n, maxi=-1000000001;
    cin>>n;
    int a[n];
    for (int i = 0; i<n; i++) 
    {
        cin >> a[i];
        maxi=max(maxi, a[i]); 
    }
    cout<<maxi;
    
    return 0;
}