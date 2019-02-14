#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    int n;
    cin >> n;
    int i = 0;
    while(n>0)
    {
        if (n % 2 != 0)
        {
            cout << i;
            return 0;
        }
    i++;
    n = n/2;
    }
}