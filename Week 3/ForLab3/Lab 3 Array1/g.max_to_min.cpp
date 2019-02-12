#include <iostream>

using namespace std;

int main ()
{
    int n,maxi=-10000000, mini=10000000;
    cin>>n;
    int a[n];

    for (int i=0; i<n; i++) 
    {
        cin>>a[i];
        maxi=max(maxi, a[i]);
        mini=min(mini, a[i]);
    } 

    for(int i=0; i<n; i++)
    {
        if(a[i]==maxi)
            cout<<mini<<" ";
        else
            cout<<a[i]<<" ";
    }
    
    return 0;
}