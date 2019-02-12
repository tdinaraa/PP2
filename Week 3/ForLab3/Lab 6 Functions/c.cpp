#include<iostream>
#include<algorithm>

using namespace std;

int a[10000];
int b[10000];
int sum=0;
int n;

void readArrays()
{
    cin >> n;
    for(int i = 0; i < n; ++i)
    {
        cin >> a[i];
    }

    for(int i = 0; i < n; ++i)
    {
        cin >> b[i];
    }
}

void FindEquality()
{
    for(int i = 0; i < n; ++i)
    {
        for(int j = 0; j< n; ++j)
        {
            if (a[i]==b[j])
            sum++;
        }   
    }
cout << sum << " ";
}

int main()
{
    readArrays();
    FindEquality();
  
    return 0;
}