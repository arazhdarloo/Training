#include <iostream>
#include <fstream>
#include <vector>

using namespace std;

class Customer
{
public:
    Customer()
    {
        fstream datas("data/customer.txt");
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
        save
    */
    void add(string id, string name, string phone)
    {
        customerList.push_back(id + "," + name + "," + phone);
    }
    string show()
    {
        string returnList;
        for (int i = 0; i < customerList.size(); i++)
        {
            returnList += customerList[i] + '\n';
        }

        return returnList;
    }


private:
    vector<string> customerList;
};