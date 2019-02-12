#include <iostream>

using namespace std;

int main () 
{
    int n, even=0, odd=0;
    cin>>n;
    for (int i=0; i<n; i++) 
    {
        int x;
        cin>>x;
        if(x%2==0) 
            even++;
        else 
            odd++;
    }
    cout<<even<<" "<<odd;
        
    return 0;
}