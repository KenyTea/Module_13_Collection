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



        }
    }
}
