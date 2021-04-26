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

         StackDemo();
        //ListDemo();
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
       public static void StackDemo()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            foreach (var item in myStack)
            Console.Write(item + ","); //prints 4,3,2,1, 

            myStack.Pop();
            Console.WriteLine();
            foreach (var item in myStack)
                Console.Write(item + ","); //prints 4,3,2,1,
            Console.WriteLine("top most element");
            myStack.Peek();
            Console.WriteLine("Number of elements present in stack" + myStack.Count);

            myStack.Clear();

            Console.WriteLine("Number of elements present in stack after calling clear method" + myStack.Count);
        }
       public static void QueueDemo()
        {
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            foreach (var id in callerIds)
            Console.Write(id); //prints 1234

            Console.WriteLine("\t" + callerIds.Dequeue());
            Console.WriteLine();
            foreach (var id in callerIds)
                Console.Write(id); //prints 1234
            Console.WriteLine("\n" + callerIds.Peek());
        }

    }

    
}

     