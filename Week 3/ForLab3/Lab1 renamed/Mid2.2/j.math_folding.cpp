#include<iostream>

using namespace std;

int main()
{
    int n,k,n1,k1;
    cin>>n>>k>>n1>>k1;
    int s1 = n*k;
    int s2 = n1*k1;
    if(s1/2 == s2)
        cout<<"Yes";
    else 
        cout<<"No";
}