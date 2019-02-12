#include<iostream>

using namespace std;

int main()
{
    int c=0,c2=0; //c2=cont vowel letters and c cout is there all letteers after first are lowercase
    string s;
    cin>>s;
    if (s.size()<3 || s.size()>15) //length is not appropriate
    {
        cout<<"Invalid name";
        return 0;
    }
    else 
    {
        if (s[0]<=65 || s[0]>=90) //not the interval of uppercase letter
        {
            cout<<"Invalid name";
            return 0; 
        }
        else 
        {
            if (s[0]=='A' || s[0]=='E' || s[0]=='I' || s[0]=='O' ||  s[0]=='U' || s[0]=='Y')
            c2++; 
            for(int i=1;i<s.size();i++)
            {
                if (s[i]>=97 && s[i]<=122) //interval of lowercase letters
                    c++;
                if (s[i]=='a' || s[i]=='e' || s[i]=='i' || s[i]=='o' ||  s[i]=='u' || s[i]=='y')
                    c2++;
            }
        }
    }

    if (c==s.size()-1 && c2!=0) //all leters  after first one is lowercase and there exists at lest one vowels 
        cout<<"Hi, "<<s;
    else 
        cout<<"Invalid name";
}