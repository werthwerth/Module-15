﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(classes => classes.Students).ToArray();
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}