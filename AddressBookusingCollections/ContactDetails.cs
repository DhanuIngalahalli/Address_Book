using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookusingCollections
{
   
    public class ContactDetails//created class for different oprations
    {

        //list declaration to store the personal details
        List<Contacts> listcontacts = new List<Contacts>();
        Dictionary<string, Contacts> dic = new Dictionary<string, Contacts>();
        List<Contacts> searchcity = new List<Contacts>();
        List<Contacts> list1 = new List<Contacts>();//list for city
        List<Contacts> list2 = new List<Contacts>();//list for state


        public void Add()//add method 
        {
            Console.WriteLine("Enter Personal Details : ");
            Console.Write("First Name : ");
            string first_name = Console.ReadLine();
            Console.Write("Last Name : ");
            string last_name = Console.ReadLine();
            Console.Write("Address : ");
            string address = Console.ReadLine();
            Console.Write("City : ");
            string city = Console.ReadLine();
            Console.Write("State : ");
            string state = Console.ReadLine();
            Console.Write("Zip Code : ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phone No. : ");
            int phone_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("E-mail ID : ");
            string email = Console.ReadLine();

            //adding the details in list
            listcontacts.Add(new Contacts()
            {
                first_name = first_name,
                last_name = last_name,
                address = address,
                city = city,
                state = state,
                zip = zip,
                phone_no = phone_no,
                email = email
            });
        }

        public void Print()//Print method 
        {
            for (int i = 0; i < listcontacts.Count; i++)
            {
                Contacts contact = listcontacts[i];

                if (!dic.ContainsKey(contact.first_name))//if condition to check the key is present or not
                {
                    dic.Add(contact.first_name, contact);//if not the add into the addressbook
                }
                else
                {
                    Console.WriteLine(" Name {0} is present", contact.first_name);
                }
            }
            foreach (var i in dic)
            {
                Console.WriteLine("First Name : " + i.Key);
                Console.WriteLine("Last Name : " + i.Value.last_name);
                Console.WriteLine("Address : " + i.Value.address);
                Console.WriteLine("City Name : " + i.Value.city);
                Console.WriteLine("State Name : " + i.Value.state);
                Console.WriteLine("Zip Code : " + i.Value.zip);
                Console.WriteLine("Phone No. : " + i.Value.phone_no);
                Console.WriteLine("Email ID : " + i.Value.email);
                Console.WriteLine("\n");
            }
        }

        //Edit method 
        public void Edit(string name, string first, string last, string add, string cityN, string stateN)
        {
            int indexOfContact = -1;
            for (int i = 0; i < listcontacts.Count; i++)
            {
                if (listcontacts[i].first_name == name)
                {
                    indexOfContact = i;
                }
            }

            var editContact = listcontacts[indexOfContact];
            editContact.first_name = first;
            editContact.last_name = last;
            editContact.address = add;
            editContact.city = cityN;
            editContact.state = stateN;
            listcontacts[indexOfContact] = editContact;

        }
        public void Delete(string firstname) //Delete method
        {
            int indexOfContact = -1;
            for (int i = 0; i < listcontacts.Count; i++)
            {
                if (listcontacts[i].first_name == firstname)
                {
                    indexOfContact = i;
                }
            }
            listcontacts.RemoveAt(indexOfContact);

        }
        public void SearchContact(string cityName, string statename)
        {
            searchcity = listcontacts.FindAll(x => (x.city == cityName || x.state == statename));//Lambda Expression

            foreach (Contacts i in searchcity)
            {
                Console.WriteLine("Person First Name : " + i.first_name);
            }
        }
        public void SearchCityState(string cityName, string stateName)
        {
            list1 = listcontacts.FindAll(x => (x.city == cityName));//to check the names in city

            foreach (Contacts i in list1)
            {
                Console.WriteLine("person in {0} City is : {1}", cityName, i.first_name);
            }
            list2 = listcontacts.FindAll(x => (x.state == stateName));//to check the Names in State
            foreach (Contacts i in list2)
            {
                Console.WriteLine("person in {0} State is : {1}", stateName, i.first_name);
            }
        }



    }



}

