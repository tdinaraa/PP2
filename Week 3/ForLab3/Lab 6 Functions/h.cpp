#include <iostream>

using namespace std;

long long getRemainder(long long number, long long division)
{
    return number % division;
}

bool isValidNumber(long long number) 
{
    while(number > 0)
    { //positive
        if (!(getRemainder(number % 10, 2) == 0)) 
        {
            return false;
        }
        number /= 10;
    }
    return true;
}

int main() 
{
    long long n;
    cin>>n;
    bool check = isValidNumber(n);
    if (check) 
        cout<<"Valid";
    else 
        cout<<"Not valid";
        
    return 0;
}
