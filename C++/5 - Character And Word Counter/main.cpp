#include <iostream>

using namespace std;

int main(){
    string text;
    cout << "enter your text: ";
    getline(cin, text);
    int charLength = 1;
    int wordLength = 1;
    for(int i = 0; i < text.length() - 1; i++){
        if (text[charLength] == ' ') wordLength++;
        charLength ++;
    }
    cout << "your text have " << charLength << " Character and " << wordLength  << " Word." << endl;


    return 0;
}