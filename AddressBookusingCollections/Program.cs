using System;

namespace AddressBookusingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
            ContactDetails op = new ContactDetails();  //Creating new object
            int count = 0;//counter to break the while loop

            while (count == 0)
            {
                Console.WriteLine("1:Add Contact");
                Console.WriteLine("2:Print Contact");
                Console.WriteLine("3:Edit Contact");
                Console.WriteLine("4:Delete");
                Console.WriteLine("5:Exit");
                int choice = Convert.ToInt32(Console.ReadLine());//variable for taking choice from the user

                switch (choice)  //switch case
                {
                    case 1:
                        Console.WriteLine("Number of Contacts: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            op.Add();
                        }
                        break;
                    case 2:
                        op.Print();//to print contact 
                        break;
                    case 3:
                        Console.WriteLine(" contact which you want to edit :-");
                        Console.WriteLine("Edit Sequence");
                        Console.WriteLine("First name,Last name,Address, City, State");
                        string name = Console.ReadLine();
                        string first = Console.ReadLine();
                        string last = Console.ReadLine();
                        string add = Console.ReadLine();
                        string cityN = Console.ReadLine();
                        string stateN = Console.ReadLine();

                        op.Edit(name, first, last, add, cityN, stateN);//to edit contact details
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name To Delete:");
                        string firstname = Console.ReadLine();
                        op.Delete(firstname);//to delete contact
                        break;
                    case 5:
                    
                        Console.Write("City Name : ");
                        string cname = Console.ReadLine();

                        Console.WriteLine("State Name : ");
                        string sname = Console.ReadLine();
                        op.SearchContact(cname, sname);
                        break;

                    default:
                        Console.WriteLine("End");//default condition
                        count++;
                        break;
                }
            }

        }

    }
}

