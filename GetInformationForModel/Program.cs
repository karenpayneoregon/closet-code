﻿using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

namespace GetInformationForModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Id = 1, 
                FirstName = "Karen", 
                LastName = "Payne", 
                BirthDate = new DateTime(1960,12,10)
            };

            person.IterateClassProperties();
            Console.ReadLine();
        }
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample model info";
        }

    }
}
