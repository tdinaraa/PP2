#include<iostream>

using namespace std;

int main()
{
    int n,c=0;
    cin>>n;
    int a[n+1];
    for (int i=1;i<n+1;i++) //because in that case i can not be 0
    {
        cin>>a[i];
        c+=a[i]*i;
    }
    cout<<c;
}