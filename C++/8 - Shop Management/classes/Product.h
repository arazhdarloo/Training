#include <iostream>
#include <vector>
#include <sstream>
#include <fstream>

using namespace std;

class Product
{
public:
    Product()
    {
        fstream datas("data/products.txt");
        string data;
        while (getline(datas, data))
        {
            productList.push_back(data);
        }
    }
    void add(string name, string price, string number)
    {
        productList.push_back(name + "," + price + "," + number);
    }
    string show()
    {
        string returnList;
        for (int i = 0; i < productList.size(); i++)
        {
            returnList += productList[i] + '\n';
        }

        return returnList;
    }
    void edit(string findName, string name, string price, string number)
    {
        int result = -1;
        for (int i = 0; i < productList.size(); i++)
        {
            string details = productList[i];
            stringstream ss(details);
            string output;
            char del = ',';

            while (getline(ss, output, del))
            {
                if (findName == output)
                {
                    result = i;
                    break;
                }
                break;
            }
        }
        if (result != -1)
            productList[result] = name + ',' + price + ',' + number;
        else
            cout << "cant find this name!";
    }
    void remove(string name)
    {
        int result = -1;
        for (int i = 0; i < productList.size(); i++)
        {
            string details = productList[i];
            stringstream ss(details);
            string output;
            char del = ',';

            while (getline(ss, output, del))
            {
                if (name == output)
                {
                    result = i;
                    break;
                }
                break;
            }
        }
        if (result != -1)
            productList.erase(productList.begin() + result);
        else
            cout << "cant find this name!";
    }
    void save()
    {
        ofstream file("data/products.txt");
        file << show();
    }

private:
    vector<string> productList;
};