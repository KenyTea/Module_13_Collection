using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_13_Collection
{
    #region Class ArrayList
    class Program
    {
        public class Mycollection
        {
            public static ArrayList NewCollection(int i)
            {
                Random r = new Random();
                ArrayList arr = new ArrayList();

                for (int j = 0; j < i; j++)
                {
                    arr.Add(r.Next(1, 50));
                }
                return arr;
            }


            public static void WriteCollection(ArrayList arr)
            {
                Console.WriteLine("ArrayList");
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(" \n");
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region ArrayList
            ArrayList col = Mycollection.NewCollection(8);
            Mycollection.WriteCollection(col);
            #endregion
            //----------------------------------------------------//
            #region Queue
            Queue<int> qe = new Queue<int>();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                qe.Enqueue(i);
            }

            Console.WriteLine("Очередь");
            foreach (int item in qe)
            {
                Console.WriteLine(item);
            }

            qe.Dequeue();

            Console.WriteLine(" \n");
            Console.WriteLine("Очередь - 0");
            foreach (int item in qe)
            {
                Console.WriteLine(item);
            }
            #endregion
            //----------------------------------------------------//
            #region Stack
            Stack<char> st = new Stack<char>();
            st.Push('a');
            st.Push('b');
            st.Push('c');
            st.Push('d');

            Console.WriteLine("Исходная очередь");
            foreach (char item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Счёт " + st.Count);
            Console.WriteLine("Удаление " + st.Pop());
            #endregion
            //----------------------------------------------------//
            #region class Dictionary
            Dictionary<int, string> m = new Dictionary<int, string>();
            m.Add(1, "Test");
            Console.WriteLine("\n");
            foreach (var item in m)
            {
                Console.WriteLine("Value: "+ item.Value + " - "+ "Key: " + item.Key); 
            }
            #endregion
            //----------------------------------------------------//
            #region SortedList
            // как и Dictionary, только сортирует 
            #endregion
        }
    }
}
