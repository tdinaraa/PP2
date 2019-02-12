#include <iostream>

using namespace std;

void reverse_print(int a[], int len) 
{
    for (int i = len - 1; i >= 0; i--) 
    {
        cout<<a[i]<<" ";
    }
}

int main() 
{
    int len, a[500500];
    cin>>len;
    for (int i = 0; i < len; i++) 
    {
        cin>>a[i];
    }
    reverse_print(a, len);
    
    return 0;
}