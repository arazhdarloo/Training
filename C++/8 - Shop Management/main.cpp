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

    p.remove("a");
    cout << '\n';
    cout << p.show();
    return 0;
}