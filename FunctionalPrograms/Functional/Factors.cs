﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{

    
        public class FactorNumber
        {
            public void Factor()
            {
                Console.WriteLine("Enter the no for which you wanna compute factors");

                int no = int.Parse(Console.ReadLine());
                Console.WriteLine("factors of {0} is: ", no);
                for (int i = 2; i <= Math.Sqrt(no); i++)



                    while (no % i == 0)
                    {
                        Console.Write(" " + i);
                        no = no / i;
                    }




            }
        }
}

