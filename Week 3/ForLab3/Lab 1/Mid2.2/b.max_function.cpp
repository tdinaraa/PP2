#include <iostream>
#include <cmath>

using namespace std;

int max(int a, int b, int c)
{
    return max(a, max(b, c));
}

int main ()
{
    int a,b,c;
    cin>>a>>b>>c;
    cout<<max(a,b,c);
    
    return 0;
}
