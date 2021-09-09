using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------

            //TODO START HERE:
            char[] arr = new char[9];
            arr[0] = '1';
            arr[1] = '2';
            arr[2] = '3';
            arr[3] = '4';
            arr[4] = '5';
            arr[5] = '6';
            arr[6] = 'a';
            arr[7] = 'b';
            arr[8] = 'c';
            var numbers = new List<int>();
            // Make a foreach loop to iterate through your character array

            // Now create a try catch
            foreach (var x in arr)
            {
                try
                {
                    int num = int.Parse(x.ToString());
                    numbers.Add(num);

                }
                catch (Exception )
                {
                    Console.WriteLine($"Unable to parse {x}");
                }
            }

            // Inside your try block
            // set your string variable to each array element in your char[] to .ToString()
            // Now, using int.Parse, parse your string variable and store in an int variable
            // Then add each int to your list

            // catch your Exception:
            // in the scope of your catch you can use the following, 

            //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection

            Console.WriteLine("-------------------");

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        private static object List<T>()
        {
            throw new NotImplementedException();
        }
    }
}
