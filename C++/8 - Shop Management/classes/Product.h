#include <iostream>
#include <vector>

using namespace std;

class Product
{
public:
    Product()
    {
        //
    }
    /*
        add
        show
        edit
        remove
        save
    */
    void add(string name, string price,string number)
    {
        productList.push_back(name + "," + price + "," + number);
    }
    string show(){
        string returnList;
        for (int i = 0;i < productList.size(); i++){
            returnList += productList[i] + '\n';
        }

        return returnList;
    }

private:
    vector<string> productList;
};