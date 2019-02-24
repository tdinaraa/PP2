#include<iostream>

using namespace std;

int main()
{
    int n, answer=0, onecounter=0;
    cin>>n;
    int a[n];
    for(int i=0;i<n;i++)
    {
        cin>>a[i];
        if (a[i] == 1)
        {
            onecounter++;
        }
        if (a[i] == 0 && onecounter!=0)
        {
            onecounter=0;
            answer++;
        }
    }
    if (onecounter==0)
        cout<<answer;
    else 
         cout<<answer+1;
   
}