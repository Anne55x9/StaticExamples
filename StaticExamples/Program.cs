﻿using System;
using System.Collections.Generic;

namespace StaticExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertCodeHere theCode = new InsertCodeHere();
            theCode.MyCode();

            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");

            Console.ReadKey();
        }
    }
}
