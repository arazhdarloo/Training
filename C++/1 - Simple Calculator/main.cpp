#include <iostream>

using namespace std;

int main(){
    cout << "\n\tEnter first number then enter a symbol(+,-,*,/) and enter secound number\n\teg: 12 + 18\n";
    while(true){
        int number1, number2;
        char symbol;
        cout << "\nenter a math problem: ";
        cin >> number1 >> symbol >> number2;

        switch (symbol)
        {
        case '+':
            cout << "result: " << number1 + number2;
            break;
        case '-':
            cout << "result: " << number1 - number2;
            break;
        case '*':
            cout << "result: " <<  number1 * number2;
            break;
        case '/':
            cout << "result: " << number1 / number2;
            break;
        
        default:
            cout << "It's a wrong symbol";
            break;
        }
    }

    cout << endl;
    return 0;
}