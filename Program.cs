﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello github");
            Console.WriteLine(pow(2,5));
            Console.WriteLine(abs(-5));
           
        }
        public static bool IsOdd(int n)
        {
            for (int i = 0; i < n; i++ )
            {
                if (n % 2 == 0)
                    return false;
            }
            return true;
        }
        public static bool IsEven(int n)
        {
            for (int i = 0; i < n;i++ )
            {
                if (n % 2 == 0)
                    return true;
            }
            return false;

        }
        public static bool IsPrime(int n)
        {
            if(n<=1)
            {
                return false;
            }
            for(int i = 2 ; i < n ; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static int pow (int x , int y)
        {
            int r = 1;
            for(int i = 1 ; i <= y ; i++)
            {
                r = r * x;
            }
            return r;
        }
        public static int abs(int n)
        {
          if ( n < 0)
              n = n * -1;
          return n;
        }
        }
    }



