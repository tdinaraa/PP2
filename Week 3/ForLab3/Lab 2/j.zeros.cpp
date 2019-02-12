#include <iostream>

using namespace std;

int main () 
{
    int n,sum=0;
    cin>>n;
    for (int i=0; i<n; i++)
    {
        int x;
        cin>>x;
        while (x!=0)
        {
            if (x%10==0)
            sum++;
            x=x/10;
        }
    }
    cout<<sum<<endl;

    return 0;
}

