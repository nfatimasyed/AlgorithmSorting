using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace BubbleSortassignment // Ref: www.youtube.com © 
{
    class Program
    {

        static void Main(string[] args)
        {
            // Bubble Sort_

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Random random = new Random();
            int[] numbers = new int[5000];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 1001);
            }
            Console.WriteLine("this is assginment Bubble Sort and Quick Sort : ");
            Console.WriteLine("Array to be sorted according to Bubble Sort algorithm : ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            int[] numberscopy = new int[5000];
            Array.Copy(numbers, 0, numberscopy, 0, numbers.Length);
            Console.Write(" the numberscopy array Bubble Sort  : ");
            for (int counter = 0; counter < numbers.Length; counter++)
            {
             Console.Write(numbers[counter]);
            }
            Console.Write(" \nThe numberscopy array Bubble Sort in numberscopy variable : ");
            for (int counter = 0; counter < numberscopy.Length; counter ++)
            {
                Console.Write(numberscopy[counter]);
            }
            
            Console.WriteLine();

            BubbleSort(numbers);
            Console.Write("The application BubbleSort took {0} seconds to run : ", stopwatch.ElapsedMilliseconds);
            stopwatch.Stop();   // Bubble Sort_


            // Quick sort_
            Stopwatch stopwatchone = new Stopwatch();
            stopwatchone.Start();
            Random randomquicksort = new Random();
            int[] numbersort = new int[5000];
            for (int i = 0; i < numbersort.Length; i++)
            {
                numbersort[i] = randomquicksort.Next(0, 1001);
            }
            Console.WriteLine("this is assginment Quick Sort : ");
            Console.WriteLine("Array to be sorted according to Quick Sort algorithm : ");

            SortArray(numbersort);
            foreach (var number in numbersort)
            {
                Console.Write(number);
            }

            int[] numberscopysort = new int[5000];
            Array.Copy(numbersort, 0, numberscopysort, 0, numbersort.Length);
            Console.Write(" the numberscopy array Quick Sort  : ");
            for (int counterone = 0; counterone < numbersort.Length; counterone++)
            {
                Console.Write(numbersort[counterone]);
            }
            Console.Write(" \nThe numberscopy array Quick Sort in numberscopy variable : ");
            for (int counterone = 0; counterone < numberscopysort.Length; counterone++)
            {
                Console.Write(numberscopysort[counterone]);
            }

            Console.WriteLine("The application Quick sort took {0} seconds to run : ", stopwatchone.ElapsedMilliseconds);
            stopwatchone.Stop(); // Quick sort_

            Console.ReadLine();
        }
        
        // Bubble sort create method :_
        private static void BubbleSort(int[] numbers)

        {
            for(int i=0;i<numbers.Length -1; i++)
            {
                for(int j = 0; j < numbers.Length -1; j++)
                {
                    if(numbers[j] > numbers[j+1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array according to the Bubble Sort algorithm :");
            foreach(var number in numbers)
            {
                Console.Write(number + " ");
            }
            // Bubble sort create method :_ 
            Console.WriteLine();
        }
        // Quick sort create method :_ 
        private static void SortArray(int[] numbersort)
        {
            Quicksort(numbersort, 0, numbersort.Length - 1);

        }
        private static void Quicksort(int[] numbersort, int leftelement, int rightelement)
        {
            int i = leftelement;
            int j = rightelement;
            var pivot = numbersort[(leftelement + rightelement) / 2];

            while (i <= j)
            {
                while (numbersort[i] < pivot)
                    i++;
                while (numbersort[j] > pivot)
                    j--;
                if (i <= j)
                {
                    var temporaryvariable = numbersort[i]; 
                    numbersort[i] = numbersort[j];
                    numbersort[j] = temporaryvariable;
                    i++;
                    j--;
                }
            }

            if (leftelement < j)
                Quicksort(numbersort, leftelement, j);
            if (i < rightelement)
                Quicksort(numbersort, i, rightelement);

            // Quick sort create method :_ 
        }

    }

}
