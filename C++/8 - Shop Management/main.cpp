#include <iostream>
#include <vector>
#include "classes/Product.h"
#include "classes/Customer.h"

using namespace std;

int main()
{
    Customer c;
    c.add("a1","Alireza","09184685357");

    cout << c.show();
    return 0;
}