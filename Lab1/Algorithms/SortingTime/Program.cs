﻿using Algorithms;
using System.Runtime.ConstrainedExecution;
using static Algorithms.SortingAlgorithms;

namespace SortingTime
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Please enter the name of the Sorting Algorithm. Here is which Sorting Algorithms are available:");
            Console.WriteLine("1. Insertion Sort");
            Console.WriteLine("2. Selection Sort");
            Console.WriteLine("3. Merge Sort");
            Console.WriteLine("4. Bubble Sort");
            Console.WriteLine("5. Quick Sort");
            Console.WriteLine("6. Lambda Expression Sort");
            Console.WriteLine("7. Exit");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            string algorithmName = Console.ReadLine();
            Console.WriteLine("Please enter the desired size of the array:");
            string size = Console.ReadLine();
            int n = int.Parse(size);
            // Creating the object of the delegate
            int[] myArray = SortingAlgorithms.Prepare(n);
            sortingDelegate sortingDelegate;

            switch (algorithmName)
            {
                case "1":
                    Console.WriteLine("You have chosen Insertion Sort");
                    sortingDelegate = new sortingDelegate(InsertionSort);
                    SortingAlgorithms.DisplayRunningTime(myArray,sortingDelegate);
                    break;

                case "2":
                    Console.WriteLine("You have chosen Selection Sort");
                    sortingDelegate = new sortingDelegate(SelectionSort);
                    SortingAlgorithms.DisplayRunningTime(myArray, sortingDelegate);
                    break;

                case "3":
                    Console.WriteLine("You have chosen Merge Sort");
                    sortingDelegate = new sortingDelegate(MergeSort);
                    SortingAlgorithms.DisplayRunningTime(myArray, sortingDelegate);
                    break;

                case "4":
                    Console.WriteLine("You have chosen Bubble Sort");
                    sortingDelegate = new sortingDelegate(BubbleSort);
                    SortingAlgorithms.DisplayRunningTime(myArray, sortingDelegate);
                    break;

                case "5":
                    Console.WriteLine("You have chosen Quick Sort");
                    sortingDelegate = new sortingDelegate(QuickSort);
                    SortingAlgorithms.DisplayRunningTime(myArray, sortingDelegate);
                    break;

                case "6":
                    Console.WriteLine("You have chosen the Lambda Expression Sorting");
                    sortingDelegate = new sortingDelegate(QuickSort);
                    SortingAlgorithms.DisplayRunningTime(myArray, sortingDelegate);
                    break;

                    case "7":
                    Console.WriteLine("Thank you for using the program.");
                    return;

                default:
                    Console.WriteLine("You have written an invalid selection. Please try again.");
                    break;
                }
            }
        }
    }
}
