﻿using classeslab1.Humans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeslab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1= new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);


            person2.DisplayPersonInfo();
            Console.WriteLine(person3);
            person1.ChangeFavoriteColour();
            person4.GetAgeInTenYears();
            Console.ReadLine();

        }
    }
}
