#include <iostream>

using namespace std;

double percent_girl(int n, int m) 
{
    double x = m * 100;
    x = x / (n * 1.0);

    return x;
}

int main () 
{
    int n,m;
    cin>>n>>m;
    cout << percent_girl(n,m);
    
    return 0;
}
