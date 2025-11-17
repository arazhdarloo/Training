#include <iostream>
#include <vector>
#include "classes/Product.h"

using namespace std;

int main()
{
    Product p;
    p.add("a","b","s");
    p.add("b","b","s");
    cout << p.show();

    p.edit("bf","c","m","s");
    cout << '\n';
    cout << p.show();
    return 0;
}