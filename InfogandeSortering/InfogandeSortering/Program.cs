﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace InfogandeSortering
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];  //Arrays for Insertionsort
            int[] b = new int[1000];
            int[] c = new int[100000];

            int[] d = new int[10];  //Arrays for Mergsort
            int[] e = new int[1000];
            int[] f = new int[100000];

            int[] g = new int[10];  //Arrays for Quicksort
            int[] h = new int[1000];
            int[] j = new int[100000];

            Random tal = new Random();  //Number generator

            Stopwatch sw = new Stopwatch();  //Stopwatch

            //Save location of times

            for (int i = 0; i < 10; i++)    //Adding numbers to the arrays of 10
            {
                a[i] = tal.Next(0, 1000000);
                d[i] = tal.Next(0, 1000000);
                g[i] = tal.Next(0, 1000000);
            }

            for (int i = 0; i < 1000; i++)  //Adding numbers to the arrays of 1000
            {
                b[i] = tal.Next(0, 1000000);
                e[i] = tal.Next(0, 1000000);
                h[i] = tal.Next(0, 1000000);
            }

            for (int i = 0; i < 100000; i++)    //Adding numbers to the arrays of 100000
            {
                c[i] = tal.Next(0, 1000000);
                f[i] = tal.Next(0, 1000000);
                j[i] = tal.Next(0, 1000000);
            }

            Console.WriteLine("Sorting algorithms timed tests");    //Writing out the type of sorting algorithm and the amount of elements inside of that array. First with 10 numbers in each array, then 1000 numbers and at last 100000 numbers.
            Thread.Sleep(5000); //Wait 5 seconds
            Console.ReadLine(); //User has to press enter to start the sorting. Has to do that for all of the other sorting parts aswell.
            Console.WriteLine("Insertionsort with 10 numbers");
            sw.Start();
            //start sorting
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Mergesort with 10 numbers");
            sw.Start();
            //start sorting
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Quicksort with 10 numbers");
            sw.Start();
            //start sorting
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Insertionsort with 1000 numbers");
            sw.Start();
            //start sorting
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Mergesort with 1000 numbers");
            sw.Start();
            //start sorting
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Quicksort with 1000 numbers");
            sw.Start();
            //start sorting
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Insertionsort with 100000 numbers");
            sw.Start();
            //start sorting
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Mergesort with 100000 numbers");
            sw.Start();
            //start sorting
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Quicksort with 100000 numbers");
            sw.Start();
            //start sorting
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            Console.ReadLine();
        }
    }
}