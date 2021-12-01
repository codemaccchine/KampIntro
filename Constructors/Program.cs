// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

namespace Constructors // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Cahit", LastName = "Arslan", City = "Ankara" };

            Customer customer2 = new Customer(2, "Mehmet", "Yılmaz", "Ankara");

            Customer customer3 = new Customer();
            customer3.Id = 3;


            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }

    }

    class Customer
    {
        //default constructor
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
