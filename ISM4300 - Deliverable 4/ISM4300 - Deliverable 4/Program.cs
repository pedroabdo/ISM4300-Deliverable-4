/*Author Pedro Nader
 * Deliverable 4 for Arrays for Managing information resources
 * This project's purpose is to Create a C# console application that computes the first 25 numbers of the Fibonacci sequence
 */

namespace ISM4300___Deliverable_4;
class Program
{
    static void Main(string[] args)
    {
        //Creating the Array
        int[] fibonacci = new int[25];

        //Defining the first numbers of the sequence
        fibonacci[0] = 0;
        fibonacci[1] = 1;
        //Count starts on 2 as we already defined 0 and 1
        for (int i = 2; i < fibonacci.Length; i++)
        {
            //apply the fibonacci formula to the index
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        //printing all the info to the user
        for (int i = 0; i < fibonacci.Length; i++)
        {
            Console.WriteLine("Fibonacci number(" + i + ") = " + fibonacci[i]);
        }

        Console.ReadKey(true);
    }
}

