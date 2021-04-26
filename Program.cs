using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            
        
        ListDemo();
        Console.ReadLine();
        }
    public static void ListDemo()
    {

        int[] arr = { 10, 20, 30 };

        //list object creation with integer datatype
        List<int> primeNumbers = new List<int>();

        //with help of add() adding integer elements into list collection
        primeNumbers.Add(1); // adding elements using add() method
        primeNumbers.Add(3);
        primeNumbers.Add(5);
        primeNumbers.Add(7);

        //adding array with help of ADDRange method
        primeNumbers.AddRange(arr);

        //iterate over all elements present in list object
        foreach (int number in primeNumbers)
        {
            Console.Write(number + "\t");
        }
        if (primeNumbers.Remove(5))
        {
            Console.WriteLine("Removed successfully");

        }
        else
        {
            Console.WriteLine("some error occured");
        }

        foreach (int number in primeNumbers)
        {
            Console.WriteLine(number + "\t");
        }
    }
}
}
     