﻿using System;

namespace CanadaSin
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                CanadaSin.runProgram();
                Console.WriteLine("Do you want to restart ?: Yes = 1 - No = 0");
                Console.Write("Your choice: ");
                choice = Int32.Parse(Console.ReadLine());
            } while (choice != 0);
        }
    }
}