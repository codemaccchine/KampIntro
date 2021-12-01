// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsIntro // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Cahit");
            Console.WriteLine(isimler.Length);
            isimler.Add("Mehmet");
            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
