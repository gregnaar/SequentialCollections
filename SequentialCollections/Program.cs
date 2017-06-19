using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = buildQueue();
            Stack stack = buildStack();
            Hashtable hashtable = buildHashtable();
            ListDictionary listDictionary = buildListDictionary();
            Dictionary<int, string> dictionary = buildDictionary();
            print(queue);
            Console.WriteLine("--------");
            print(stack);
            Console.WriteLine("--------");
            print(hashtable);
            Console.WriteLine("--------");
            print(listDictionary);
            Console.WriteLine("--------");
            print(dictionary);
            
            Console.ReadKey();
        }

        private static Dictionary<int, string> buildDictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict[44] = "United Kingdom";
            dict[33] = "France";
            dict[31] = "Netherlands";
            dict[55] = "Brazil";
            dict[257] = "Burundi";
            dict[1] = "Canada";
            dict[20] = "Egypt";
            return dict;
        }

        private static ListDictionary buildListDictionary()
        {
            ListDictionary listDictionary = 
                new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));
            listDictionary["Estados Unidos"] = "United States of America";
            listDictionary["Canadá"] = "Canada";
            listDictionary["España"] = "Spain";
            return listDictionary;
        }

        private static Hashtable buildHashtable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("0", "Zero");
            hashtable.Add("1", "One");
            hashtable.Add("2", "Two");
            hashtable.Add("3", "Three");
            hashtable.Add("4", "Four");
            hashtable.Add("5", "Five");
            hashtable.Add("6", "Six");
            hashtable.Add("7", "Seven");
            hashtable.Add("8", "Eight");
            hashtable.Add("9", "Nine");

            return hashtable;
        }

        private static Stack buildStack()
        {
            Stack stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");
            return stack;
        }

        private static Queue buildQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");
            return queue;
        }

        private static void print(Dictionary<int, string> dict)
        {
            Console.WriteLine("The 33 Code is for: {0}", dict[33]);

            foreach(KeyValuePair<int, string> country in dict)
            {
                Console.WriteLine(string.Format
                    ("Contry Name: {0} Number: {1}", country.Value, country.Key));
            }
        }

        private static void print(ListDictionary listDictionary)
        {
            Console.WriteLine(listDictionary["españa"]);
            Console.WriteLine(listDictionary["CANADÁ"]);
        }

        private static void print(Hashtable hashtable)
        {
            string numbers = "23459831";
            foreach(char number in numbers)
            {
                if (hashtable.Contains(number.ToString()))
                {
                    Console.WriteLine(hashtable[number.ToString()]);
                }   
            }
        }

        private static void print(Queue queue)
        {
            int i = 1;
            while (queue.Count != 0)
            {
                var element = queue.Dequeue();
                Console.WriteLine(string.Format("No.{0} element from queue: {1}", i, element));
                i++;
            }
        }
        private static void print(Stack stack)
        {
            int i = 1;
            while (stack.Count != 0)
            {
                var element = stack.Pop();
                Console.WriteLine(string.Format("No.{0} element from stack: {1}", i, element));
                i++;
            }

        }
    }
}
