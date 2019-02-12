#include <iostream>

using namespace std;

int main()
{
    int n;
    cin >> n;
    for (int i = 1; i <= n; i++) 
    {
        for (int j = 1; j <= n - i; j++)
            cout << ".";
            cout<<i; // vyvodit po ocheredi
        for (int k = 1; k <= i - 1; k++) // number of dots after tsifra
            cout << ".";
            cout << endl;
    }
    return 0;
}