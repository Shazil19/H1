using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Customer> customers = new Queue<Customer>();

            int i = 0;

            while (true)
            {

                Console.WriteLine(
                    "\nType 1.\t to Add\n" +
                    "Type 2.\t to remove\n" +
                    "Type 3.\t to Show the number of items\n" +
                    "Type 4.\t to Show min and max items\n" +
                    "Type 5.\t to print all items\n" +
                    "Type 6.\t to exit\n");

                int type = int.Parse(Console.ReadLine());

                switch (type)
                {
                    
                    case 1:

                        i++;

                        Console.WriteLine("\nYou have type 1.");

                        Console.Write("\nPlease type the name: ");

                        string name = Console.ReadLine();

                        Console.WriteLine("\nCustomer Number is: " + i);

                        int customernumber = i;

                        Console.Write("\nPlease type the amount of items you have: ");

                        int itemscustomerbought = int.Parse(Console.ReadLine());

                        Customer customer = new Customer(name, customernumber, itemscustomerbought);

                        customers.Enqueue(customer);

                        break;

                    case 2:

                        Console.WriteLine("\nYou have type 2.");

                        Console.WriteLine("\nThe first customer has been removed.");

                        customers.Dequeue();

                        break;

                    case 3:

                        Console.WriteLine("\nYou have type 3.");

                        Console.WriteLine("\nTheir are a total of " + customers.Count + " Customers in the Queue");

                        break;

                    case 4:

                        Console.WriteLine("\nYou have type 4.");

                        Customer firstone = customers.First();

                        Customer Lastone = customers.Last();

                        Console.WriteLine(string.Format("\nFirst One {0} and Last one {1}", firstone.Name, Lastone.Name));

                        break;

                    case 5:

                        Console.WriteLine("\nYou have type 5.");
                        
                        if (customers.Count == 0)
                        {
                            Console.WriteLine("\nTheir are no customers in the shop");
                        }
                        else
                        {
                            foreach (Customer customer1 in customers)
                            {
                                Console.WriteLine("\n" + 
                                    "Name: " + customer1.Name + "     " +
                                    "Customer Number: " + customer1.CustomerNumber + "      " +
                                    "Amount of items Customer bought:" + customer1.ItemsCustomerBought);
                            }
                        }
                        

                        break;

                    case 6:

                        Console.WriteLine("\nYou have type 6.\n");

                        break;
                }

                if (type == 6)
                {
                    break;
                }
            }
            Console.ReadKey();
        }

        public class Customer
        {
            public string Name { get; set; }

            public int CustomerNumber { get; set; }

            public int ItemsCustomerBought { get; set; }

            public Customer(string name, int customernumber, int itemscustomerbought)
            {
                Name = name;
                CustomerNumber = customernumber;
                ItemsCustomerBought = itemscustomerbought;
            }

            public override string ToString()
            {
                return "Customer Name: " + Name + "Customer Number: " + CustomerNumber + "Item Customer bought: " + ItemsCustomerBought;
            }
        }
    }
}
