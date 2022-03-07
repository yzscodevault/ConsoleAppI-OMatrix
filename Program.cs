using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDArrayIO();//call 2D array I/O
            Add2Arrarys();//call production of two 2D arrays I/O
            Console.WriteLine("The following is to show method and overloading method");//create overloaded methods
            Console.WriteLine($"The result of function Add(int a, int b) is: {Add(1, 2)}");
            Console.WriteLine($"The result of overloading function Add(int a, int b, int c) result is: {Add(1, 2, 3)}");
            Console.WriteLine($"The result of function Multiply(float a, float b) result is: {Multiply(2, 3)}");
            Console.WriteLine($"The result of overloading function Multiply(float a, float b, float c) result is: {Multiply(4, 2, 3)}");
            Console.ReadLine();
        }
        static void TwoDArrayIO()
        {
            try
            {
                Console.WriteLine("This function is just to display entered arrary/matrix: ");
                Console.WriteLine("Please enter how many Rows of your matrix");
                int rowNmbrs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter how many Columns of your matrix");
                int colNmbrs = Int32.Parse(Console.ReadLine());
                int[,] twoDArray = new int[rowNmbrs, colNmbrs];
                for (int i = 0; i < rowNmbrs; i++)
                {
                    for (int j = 0; j < colNmbrs; j++)
                    {
                        Console.WriteLine("Please enter the element for row {0}, column {1}:", i, j);
                        twoDArray[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                //output/display the matrix
                Console.WriteLine("The matrix is displayed as follows:");
                for (int i = 0; i < rowNmbrs; i++)
                {
                    for (int j = 0; j < colNmbrs; j++)
                    {
                        Console.Write("|{0}|\t", twoDArray[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            catch (FormatException fe)
            { Console.WriteLine(fe.Message + "\n" + "Please only enter digits as array/matrix elements"); }
        }
        static void Add2Arrarys()
        {
            try
            {
                Console.WriteLine("This function is just to display addition of entered arrary/matrix: ");
                //input for first array
                Console.WriteLine("Please enter how many rows for your array");
                int rowArray = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter how many columns for your array");
                int colArray = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the elements for your first array");
                int[,] array1 = new int[rowArray, colArray];
                for (int i = 0; i < rowArray; i++)
                {
                    for (int j = 0; j < colArray; j++)
                    {
                        Console.WriteLine($"Now, please enter the element at row {i}, column {j} of the first array: ");
                        array1[i, j] = Int32.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("The first array is:");
                int lineBreaker = 1;
                foreach (int i in array1)
                {
                    Console.Write($"|{i}|\t");
                    if (lineBreaker == colArray) { Console.WriteLine(); }
                    lineBreaker++;
                }
                Console.WriteLine();
                Console.WriteLine("Please enter the elements for your second array, same amount of rows and columns");
                //input for second array                
                int[,] array2 = new int[rowArray, colArray];
                for (int i = 0; i < array2.GetLength(0); i++)
                {
                    for (int j = 0; j < array2.GetLength(1); j++)
                    {
                        Console.WriteLine($"Now, please enter the element at row {i}, column {j} of the second array: ");
                        array2[i, j] = Int32.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("\nThe second array is:");
                lineBreaker = 1;
                foreach (int i in array2)
                {
                    Console.Write($"|{i}|\t");
                    if (lineBreaker == colArray) { Console.WriteLine(); }
                    lineBreaker++;
                }
                //add array1 and array2 then output as array3
                int[,] sumArray = new int[rowArray, colArray];
                for (int i = 0; i < rowArray; i++)
                {
                    for (int j = 0; j < colArray; j++)
                    {
                        sumArray[i, j] = array1[i, j] + array2[i, j];
                    }
                }
                Console.WriteLine("\nThe addition of first and second array will be:");
                lineBreaker = 1;
                foreach (int i in sumArray)
                {
                    Console.Write($"|{i}|\t");
                    if (lineBreaker == colArray) { Console.WriteLine(); }
                    lineBreaker++;
                }
                Console.WriteLine();
            }
            catch(FormatException fe) { Console.WriteLine(fe.Message + "\n" + "Please only enter digits as array/matrix elements"); }
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        //overloading method
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static float Multiply(float a, float b)
        {
            return a * b;
        }
        //overloading method
        static float Multiply(float a, float b, float c)
        {
            return a * b * c;
        }
    }
}
