#include <iostream>
#include <cmath>

using namespace std;

int max(int a, int b, int c, int d)
{
    return max(a, max(b, max(c, d)));
}

int main ()
{
    int a,b,c,d;
    cin>>a>>b>>c>>d;
    cout<<max(a,b,c,d);

    return 0;
}