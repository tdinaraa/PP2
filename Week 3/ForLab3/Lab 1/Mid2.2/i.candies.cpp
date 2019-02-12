#include<iostream>

using namespace std;

int main()
{
    int n,k;
    cin>>n>>k;
    if(n%3==0 || k%3 ==0 || (n+k)%3==0)
        cout<<"Yes";
    else 
        cout<<"No";
}
