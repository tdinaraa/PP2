#include<iostream>
#include<algorithm>

using namespace std;

int diff(int a, int b)
{
    return abs(a-b);
}

int main () 
{
    int a,b;
    cin>>a>>b;
    cout<<diff(a,b);

    return 0;
}