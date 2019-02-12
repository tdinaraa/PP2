#include <iostream>

using namespace std;

bool check(int x)
{
    int y = 0;
    int w = 0;
    while (w) 
    {
        y = x % 10;
        w += x % 10;
        x /= 10;
    }
    if (w % y == 0) 
    {
        return true;
    }
    else 
    {
        return false;
    }
}

int main () 
{
    int x;
    cin >> x;
    if (check(x)) 
        cout << "Yes";
    else
        cout << "No";
        
    return 0;
}
