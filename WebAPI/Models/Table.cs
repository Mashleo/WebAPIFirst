﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public static class Table
    {

        public static void Print(List<Person> person)
        {

            for (int i = 0; i < person.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"|NAME\t|AGE\t|ADRESS\t");
                }
                Console.WriteLine($"|{person[i].Name}\t|{person[i].Age}\t|{person[i].Adress.Country} {person[i].Adress.State} {person[i].Adress.Street}\t|");
            }

        }

    }
}
