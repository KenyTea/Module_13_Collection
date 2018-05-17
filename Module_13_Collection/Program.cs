using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_13_Collection
{
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

        static void Main(string[] args)
        {
            ArrayList col = Mycollection.NewCollection(8);
            Mycollection.WriteCollection(col);

            //----------------------------------------------------//

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
        }
    }
}
