#include<iostream>
#include<sstream>
#include<algorithm>

using namespace std;

int add(int a, int b)
{
    return a+b;
}

int main () 
{
    int a,b;
    cin>>a>>b;
    cout<<add(a,b);

    return 0;
}