#include <iostream>
#include <vector>
#include "classes/Product.h"

using namespace std;

int main()
{
    Product p;
    p.add("keyboard","150000","4");

    cout << p.show();
    p.save();
    return 0;
}