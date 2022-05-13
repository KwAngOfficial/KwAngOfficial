using System;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace SecondConsolApp
{

    class Program
    {

        static void Main(string[] args)
        {
            String FistName;
            String LastName;
            String FullName;
            int index_SubStr;
            String SubStr;
            int Age;
            Console.Write("Enter Firstname:");
            FistName = Console.ReadLine();
            Console.Write("Enter Lastname:");
            LastName = Console.ReadLine();
            Console.Write("Enter age:");
            FullName = FistName + " " + LastName;

            index_SubStr= FullName.IndexOf(LastName[0]);
            SubStr=FullName.Substring(index_SubStr);

            Age= Convert.ToInt32(Console.ReadLine());

            String inf = $"Name: {SubStr} \nAge: {Age}";

            Console.WriteLine(inf);
            Console.WriteLine("a\bb");
            Console.WriteLine("Hello Wold");
        }
    }
}
