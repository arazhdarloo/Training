#include <iostream>
#include <ctime>

using namespace std;

int main(){
    int year;

    cout << "enter year of your birthday: ";
    cin >> year;
    time_t now = time(0);
    tm *ltm = localtime(&now);
    
    int age = (1900 + ltm->tm_year) - year;
    cout << "youre age is " << age << endl;
    
    return 0;
}