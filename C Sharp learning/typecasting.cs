using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_learning
{
    class typecasting
    {
        static void Main()
        {
            /*Read line () is used to read the line of data in the form of string and returns
             only for reading the data we need type conversion */
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("name="+name);
            Console.WriteLine("age=" + age);
            Console.WriteLine("name=" + name);



        }
    }
}
