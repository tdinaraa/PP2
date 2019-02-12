#include <iostream>

using namespace std;

int pos(int x) 
{
if (x<0) 
    return x* -1;
    return x;
}

int main () 
{
    int x;
    cin>>x;
    cout << pos(x);
    
    return 0;
}

