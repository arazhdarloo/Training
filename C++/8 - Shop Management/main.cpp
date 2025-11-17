#include <iostream>
#include <vector>
#include "classes/Product.h"

using namespace std;

int main()
{
    Product p;
    p.add("a","b","s");
    cout << p.show();

    return 0;
}