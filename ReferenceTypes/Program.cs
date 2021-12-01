// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

namespace ReferenceTypes // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ////int, decimal, float, enum, boolean value types
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine("Sayi 1 : " + sayi1);

            ////arrays, class, interface... reference types
            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine("Sayilar1[0] : " + sayilar1[0]);


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Cahit";

            person2 = person1;
            person1.FirstName = "Arslan";

            Console.WriteLine(person2.FirstName);



            Customer customer = new Customer();
            Person person3 = new Person();
            person3 = customer;
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567890";

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);


            Employee employee = new Employee();
            employee.FirstName = "Veli";


            PersonManager personManager = new PersonManager();
            personManager.Add(person1);
            personManager.Add(customer);
            personManager.Add(employee);



            Console.ReadLine();
        }
    }

    //base class : Person
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
