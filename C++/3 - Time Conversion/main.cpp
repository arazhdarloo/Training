#include <iostream>

using namespace std;

int main(){
    int second, minutes, hour;
    cout << "Enter seconds: ";
    cin >> second;
    if(second >= 60){
        minutes = second / 60;
        if (minutes >= 60){
            hour = minutes / 60;
            minutes = minutes % 60;
            second = second % 60;

            cout << hour << " hour and " << minutes << " minutes and " <<  second << " secound" << endl;
        }else{
            second = second % 60;

            cout << minutes << " minutes and " <<  second << " secound" << endl;
        }
    }else{
        cout << second << " second" << endl;
    }
}