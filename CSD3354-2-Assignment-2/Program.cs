﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Isha Garg c0732132
//Dheeraj Jain c0723560
//CSD3354 Section 3
//Assignment2
//March 6, 2019
namespace CSD3354_2_Assignment_2
{
    class Program
    public class DelegateExercises
    {
        static void Main(string[] args)
        public delegate void MyDelegate();
        void Methodl()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Method1");
            Console.ReadLine();
        }

        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Methodl);
            myDelegate();
        }
    }
}
