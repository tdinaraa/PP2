#include<iostream>

using namespace std;

int mymax(int a, int b, int c)
{
   int max1 = max(a,b);
   int max2 = max(max1, c);
   return max2;
}
int main()
{
    int a,b,c;
    cin>>a>>b>>c;
    cout<<mymax(a,b,c)<<endl;
}