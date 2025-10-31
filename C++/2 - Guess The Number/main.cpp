#include <iostream>

using namespace std;

int main(){
    srand(time(0));
    cout << "we made a number between 0-9, Guess that number."  << endl;

    while (true)
    {
        int rnd = rand() % 10;
        int guess;

        cout << "enter number: ";
        cin >> guess;

        guess == rnd ? cout << "\nits true!" << endl : cout << "\nits false! the true number is " << rnd << endl;
    }
    

    return 0;
}
