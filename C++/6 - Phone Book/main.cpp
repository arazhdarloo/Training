#include <iostream>
#include <fstream>
#include <vector>
#include <string>
#include <sstream>

using namespace std;

int main()
{
    // read data file and push to vactor
    fstream datas("data.txt");
    vector<string> contacts;

    string data;
    while (getline(datas, data))
    {
        contacts.push_back(data);
    }

    while (true)
    {
        /*
            1 -> show list
            2 -> add a contact
            3 -> edit a contact
            4 -> search
            5 -> save changes
        */
        cout << "1 -> show list\n2 -> add a contact\n3 -> edit a contact\n4 -> search\n5 -> save" << endl;
        int option;
        cin >> option;
        switch (option)
        {
        case 1:
            // show the contacts
            cout << "list of contacts: " << endl;
            for (int i = 0; i < contacts.size(); i++)
                cout << contacts[i] << endl;

            break;
        case 2:
        {
            /*
                ----add----
                enter the contact name : 'ali'
                enter the number : '000000000'
            */
            string name, number;
            cout << "enter name : ";
            cin >> name;
            cout << "enter number : ";
            cin >> number;

            contacts.push_back(name + "," + number);

            cout << "youre contact add\n"
                 << endl;

            break;
        }
        case 3:
            /*
                ----edit----
                1 -> edit number
                2 -> edit name
            */
            cout << "1 -> edit number\n2 -> edit name" << endl;
            int sOption;
            cin >> sOption;
            if (sOption == 1)
            {
                string name;
                cout << "enter the contact name : ";
                cin >> name;
                int result = -1;
                for (int i = 0; i < contacts.size(); i++)
                {
                    string details = contacts[i];
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
                    }
                }
                if (result != -1)
                {
                    string nName;
                    cout << "enter new name : ";
                    cin >> nName;

                    vector<string> eData;
                    stringstream ss(contacts[result]);
                    string output;
                    char del = ',';
                    while (getline(ss, output, del))
                    {
                        eData.push_back(output);
                    }

                    contacts[result] = nName + "," + eData[1];
                    cout << "edited";
                }
                else
                {
                    cout << "not found!";
                }
            }
            else if (sOption == 2)
            {
                string number;
                cout << "enter the contact number : ";
                cin >> number;
                int result = -1;
                for (int i = 0; i < contacts.size(); i++)
                {
                    string details = contacts[i];
                    stringstream ss(details);
                    string output;
                    char del = ',';

                    while (getline(ss, output, del))
                    {
                        if (number == output)
                        {
                            result = i;
                            break;
                        }
                    }
                }
                if (result != -1)
                {
                    string nNumber;
                    cout << "enter new number : ";
                    cin >> nNumber;

                    vector<string> eData;
                    stringstream ss(contacts[result]);
                    string output;
                    char del = ',';
                    while (getline(ss, output, del))
                    {
                        eData.push_back(output);
                    }

                    contacts[result] = eData[0] + "," + nNumber;
                    cout << "edited";
                }
                else
                {
                    cout << "not found!";
                }
            }

            break;

        case 4:
        {
            /*
                // search with name
            */
            string name;
            cout << "enter the name : ";
            cin >> name;
            int result = -1;
            for (int i = 0; i < contacts.size(); i++)
            {
                string details = contacts[i];
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
                }
            }
            cout << "contact info : " << contacts[result] << endl
                 << endl;

            break;
        }
        case 5:
        {
            string output;
            for (int i = 0; i < contacts.size(); i++)
            {
                output += contacts[i] + '\n';
            }
            cout << output;
            ofstream out("data.txt");
            out << output;
            cout << "saved" << endl;
            break;
        }
        default:
            break;
        }
    }

    return 0;
}