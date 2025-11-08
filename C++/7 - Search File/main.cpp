#include <iostream>
#include <filesystem>

using namespace std;
namespace fs = filesystem;

int main()
{
    string name;
    cout << "enter name of file : ";
    cin >> name;
    string path = ".";

    int status = -1;
    for (const auto &entry : fs::directory_iterator(path))
    {
        name == entry.path().filename() ? status = 1 : status;
    }

    status == -1 ? cout << "this file doesn't exist" << endl : cout << "founded" << endl;

    return 0;
}