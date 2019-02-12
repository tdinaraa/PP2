#include <iostream>
#include <cmath>

using namespace std;

int sum_of_elements(int n)
{
    int sum=0;
    while (n > 0) 
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

int main ()
{
    int n;
    cin>>n;
    cout<<sum_of_elements(n);

    return 0;
}