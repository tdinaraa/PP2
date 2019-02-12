#include <iostream>
using namespace std;

int main()
{
    int n;
    cin >> n;
    int a[n][n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cin >> a[i][j];
        }
    }
    if (n == 1) // 1 elemet, razmer massiva 
    {
        cout << 0;
        return 0;
    }
    // mojno i ne pisat
    int max = -1000001;
    int max2= -1000001;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (max < a[i][j])
            {
                max2 = max;
                max = a[i][j];
            }
            if (max2< a[i][j] && a[i][j] < max) // for eg 1,3,9,7
            {
                max2 = a[i][j];
            }
        }
    }
    if (max2==-1000001)  //the same elements, max then will not change
    {
        cout << 0;
    }
    else cout << max2;
}
