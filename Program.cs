using System;
using System.Collections.Generic;

namespace Basic13 {
    class Program {

        // Find Max

        public static int FindMax (int[] numbers) {
            int max = numbers[0];
            foreach (int num in numbers) {
                if (num > max) {
                    max = num;
                }
            }
            Console.WriteLine ($"Array Max Value: {max}.");
            return max;
        }

        //Get Average

        public static int GetAverage (int[] numbers) {
            int sum = numbers[0];
            foreach (int num in numbers) {
                sum = sum + num;
            }
            int arrAvg = sum / numbers.Length;
            Console.WriteLine ($"Array Average: {arrAvg}");
            return arrAvg;
        }

        //Array with Odd Numbers

        public static int[] OddArray () {
            int[] newArr = new int[255];
            for (int i = 0; i <= 255; i++) {
                if (i % 2 == 1) {
                    newArr[i] = i;
                    Console.WriteLine (newArr[i]);
                }
            }
            return newArr;
        }

        // Greater than Y

        public static int GreaterThanY (int[] numbers, int y) {
            int count = 0;
            foreach (int num in numbers) {
                if (num > y) {
                    count++;
                }
            }
            Console.WriteLine ($"There are {count} number(s) greater than your Y value, {y}, in the array.");
            return count;
        }

        // Square the Values

        public static int[] SquareArrayValues (int[] numbers) {
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = numbers[i] * numbers[i];
                Console.WriteLine (numbers[i]);
            }
            return numbers;
        }

        // Eliminate Negative Numbers

        public static int[] EliminateNegatives (int[] numbers) {
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] < 0) {
                    numbers[i] = 0;
                }
                Console.WriteLine (numbers[i]);
            }
            return numbers;
        }

        // Min, Max, and Average

        public static string MinMaxAverage (int[] numbers) {
            int min = numbers[0];
            int max = numbers[0];
            int sum = numbers[0];

            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] < min) {
                    min = numbers[i];
                }
                if (numbers[i] > max) {
                    max = numbers[i];
                }
                sum = sum + numbers[i];
            }

            float average = ((float) sum / numbers.Length);
            string summary = $"Min: {min}, Max: {max}, Average: {average}}";

            Console.WriteLine (summary);
            return summary;
        }

        // Shifting the values in an array

        public static int[] ShiftValues (int[] arr) {
            for (int i = 0; i < arr.Length - 1; i++) {
                arr[i] = arr[i + 1];
                Console.WriteLine (arr[i]);
            }
            int lastVal = arr[arr.Length - 1] = 0;
            Console.WriteLine (lastVal);
            return arr;
        }

        // Number to String

        public static List<object> NumToString (int[] arr) {
            List<object> dojoList = new List<object> ();
            for (var i = 0; i < arr.Length; i++) {
                if (arr[i] < 0) {
                    dojoList.Add ("Dojo");
                } else {
                    dojoList.Add (arr[i]);
                }
                Console.WriteLine (dojoList[i]);
            }
            return dojoList;
        }




        static void Main (string[] args) {
            Console.WriteLine ("Basic 13!");

            // Print 1-255

            for (int i = 1; i <= 255; i++) {
                Console.WriteLine (i);
            }

            // Print odd numbers between 1-255
            for (int i = 1; i <= 255; i++) {
                if (i % 2 == 1) {
                    Console.WriteLine (i);
                }
            }

            Print Sum as you go

            int sum = 0;
            for (int i = 0; i <= 255; i++) {
                sum = sum + i;
                Console.WriteLine ("New number: {0}, Sum: {1}", i, sum);
            }

            // Iterating through an Array

            int[] X = { 1, 5, 8, 12, 53, 13 };
            foreach (int value in X) {
            Console.WriteLine (value);
            }

        }
    }
}