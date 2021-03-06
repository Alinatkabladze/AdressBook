﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            openMenubar();
      
            }       
        
        public static List<AdressBook> adresses = new List<AdressBook>();

        public static void openMenubar()
        {
            AdressBook book = new AdressBook();
            do
            {
                Console.WriteLine(" Please choose operation from menu: \n Add \n Delete \n Exit");
                string input = Console.ReadLine();
                if (input == "Add")
                {
                    addAdress();
                }
                  
                
                foreach (var str in adresses)
                {
                    var stringToCheck = str.ToString();
                    bool exit = stringToCheck.Any("Exit".Contains);
                    if (exit)
                    {
                        Console.WriteLine("Operation is rejected by the user");
                        return;
                        
                    }
                    else if (input=="Delete")
                    {
                        removeAdressById(book.Id);
                   
                        return;
                    }
                    else
                    {

                        continue;
                    }

                }
                foreach (AdressBook item in adresses)
                {
                    Console.WriteLine(item);
                }


            } while (true);
            
        }
        public static void addAdress()
        {
            int i = 1;
            Console.WriteLine("Input country : ");
            string country = Console.ReadLine();
            Console.WriteLine("Input city : ");
            string city = Console.ReadLine();
            Console.WriteLine("Input adress : ");
            string adress = Console.ReadLine();
            Console.WriteLine("Input phone : ");
            string phone = Console.ReadLine();
            Console.WriteLine("Input fullname : ");
            string fullname = Console.ReadLine();

            adresses.Add(new AdressBook()
            {
                Id = i,
                Country = country,
                City = city,
                Adress = adress,
                Phone = phone,
                FullName = fullname
            });
            i++;
        }

    

    public static void removeAdressById(int id)

        {
            Console.Write("Input id to Delete : ");
            id = Convert.ToInt32(Console.ReadLine());
            var deletableadress = adresses.FirstOrDefault(e => e.Id == id);
            adresses.RemoveAt(0);
            adresses.Remove(deletableadress);
            Console.WriteLine("Chosen Adress was deleted");
            foreach (AdressBook item in adresses)
            {

                Console.WriteLine(item);
            }
        }


        public class AdressBook
        {
            public int Id;
            public string Country;
            public string City;
            public string Adress;
            public string Phone;
            public string FullName;

            public override string ToString()
            {
                return string.Format("Id={0},Country = {1}, City = {2}, Adress = {3},Phone={4},FullName={5}", Id, Country, City, Adress, Phone, FullName);
            }
        }

    }
}

       







