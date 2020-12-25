using System;
using System.Collections;
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
            //************ Array List ********************
            //ArrayList Al = new ArrayList();
            //Al.Add("Sno");
            //Al.Add(1);
            //Al.Add(1.0f);
            //Al.Add(2.09898);
            //Al.Add(DateTime.Today);

            //foreach (object o in Al)
            //{

            //    Console.WriteLine("Arry list item is {0}", o.ToString());
            //}

            //Console.WriteLine("Array list Capacity {0}", Al.Capacity);
            //Console.ReadLine();

            //************ HashTable ********************

            //Hashtable HT = new Hashtable();

            //HT.Add(1, "C#");
            //HT.Add(2, "Ado.Net");
            //HT.Add(3, "ASP.Net");
            //HT.Add(4, "MVC");
            //HT.Add(5, "Java Script");

            //foreach (DictionaryEntry DE in HT)
            //{

            //    Console.WriteLine("Key is {0}  ; Value is {1}", DE.Key, DE.Value);
            //}
            //Console.ReadLine();

            //************ SortedList ********************

            //SortedList SL = new SortedList();

            //SL.Add(1, "C#");
            //SL.Add(2, "Ado.Net");

            //SL.Add(5, "Java Script");
            //SL.Add(3, "ASP.Net");
            //SL.Add(4, "MVC");

            //foreach (DictionaryEntry DE in SL)
            //{

            //    Console.WriteLine("Key is {0}  ; Value is {1}", DE.Key, DE.Value);
            //}
            //Console.ReadLine();

            //************ Stack (LIFO)********************

            //Stack St = new Stack();
            //St.Push(1);
            //St.Push(3.256);
            //St.Push("Name");

            //foreach(object O in St)
            //{

            //    Console.WriteLine("Stack Value is : {0}", O.ToString());
            //}

            //Console.ReadLine();
            //************ Queue (FIFO)********************

            //Queue Q = new Queue();
            //Q.Enqueue(1);
            //Q.Enqueue(3.256);
            //Q.Enqueue("Name");

            //foreach (object O in Q)
            //{

            //    Console.WriteLine("Queue Value is : {0}", O.ToString());
            //}

            //Console.ReadLine();

            //************ LIST ********************

            //List<int> Mylist = new List<int>();

            //Mylist.Add(1);
            //Mylist.Add(10);
            //Mylist.Add(1000);
            //Mylist.Add(10000);

            //foreach(int i in Mylist)
            //{
            //    Console.WriteLine("Item is {0}", i.ToString());
            //}
            //Console.ReadLine();

            //************ Dictionary ********************

            //Dictionary<int, string> Di = new Dictionary<int, string>();

            //Di.Add(1, "Fname");
            //Di.Add(2, "Lname");
            //Di.Add(3, "Designation");
            //Di.Add(4, "Salary");
            //Di.Add(5, "Location");

            //foreach(KeyValuePair<int,string> KVP in Di)
            //{
            //    Console.WriteLine("Key and Values are {0} , {1}", KVP.Key, KVP.Value);

            //}

            //Console.ReadLine();

            //************ SortedList ********************
            //SortedList<int, string> SL = new SortedList<int, string>();

            //SL.Add(5, "Location");
            //SL.Add(1, "Fname");
            //SL.Add(2, "Lname");
            //SL.Add(3, "Designation");
            //SL.Add(4, "Salary");


            //foreach (KeyValuePair<int, string> KVP in SL)
            //{
            //    Console.WriteLine("Key and Values are {0} , {1}", KVP.Key, KVP.Value);

            //}

            //Console.ReadLine();

            //************ Stack (LIFO) Generic********************

            //Stack<string> St = new Stack<string>();
            //St.Push("1");
            //St.Push("3.256");
            //St.Push("Name");

            //foreach (object O in St)
            //{

            //    Console.WriteLine("Stack Value is : {0}", O.ToString());
            //}

            //Console.ReadLine();
           // ************Queue(FIFO) Generic********************

            Queue<int> Q = new Queue<int>();
            Q.Enqueue(1);
            Q.Enqueue(3);
            Q.Enqueue(4);

            foreach (object O in Q)
            {

                Console.WriteLine("Queue Value is : {0} + Test Jagadeesh ", O.ToString());
            }

            Console.ReadLine();
            Console.Read();
            //Mahendra
            //Jagadeesh1
            //Jayaprakash pulu Govinda Bhat
        }
    }
}
