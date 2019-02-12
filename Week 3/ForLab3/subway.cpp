#include <iostream>
#include <string>

using namespace std;

int main()
{
    int x,y,z;
    cin>>x>>y>>z;
    if (x*y==z)
        cout<<"No difference";
    else
    {
        if (x*y>z)
        cout<<"Yes";
    else 
        cout<<"No";
    }
    
    return 0;
}