
using System;
using System.Collections;

//namespaces used for encapsulation
namespace CollectionApplication {
   
   class Program {
      
      static void Main(string[] args) {
         ArrayList a = new ArrayList();
         
         Console.WriteLine("Adding some numbers:");
         a.Add("1");
         a.Add("2");
         a.Add("3");
         a.Add("4");
         a.Add("5");
         a.Add("6");       
         a.Add("7");
         
         //capacity of arraylist
         Console.WriteLine("Capacity: {0} ", a.capacity);

         //number of elements in current arraylist
         Console.WriteLine("Count: {0}", a.Count);
         
         //sout.print in java but like this in c#
         Console.Write("Content: ");

         //:3 no need i++? sweet!
         //print arraylist with simple for loop
         foreach (int i in a) {
            Console.Write(i + " ");
         }
         
         Console.WriteLine();
         Console.Write("Sorted Content: ");
         a.Sort();
         foreach (int i in a) {
            Console.Write(i + " ");
         }
         Console.WriteLine();
      }
   }
}
