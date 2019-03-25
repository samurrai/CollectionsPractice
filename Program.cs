using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);
            arrayList.Add(6);
            for (int i = 0; i < arrayList.Count; i++)
            {
                if ((int)arrayList[i] % 2 == 0)
                {
                    arrayList.RemoveAt(i);
                }
            }
            foreach (var element in arrayList)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            int avg = (int)list.Average();
            foreach(var element in list)
            {
                if(element > avg)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
