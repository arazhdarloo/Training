#include <iostream>
#include <fstream>
#include <vector>

using namespace std;

class Customer
{
public:
    Customer()
    {
        fstream datas("data/products.txt");
        string data;
        while (getline(datas, data))
        {
            customerList.push_back(data);
        }
    }
    /*
        add
        remove
        show
        getData
    */

private:
    vector<string> customerList;
};