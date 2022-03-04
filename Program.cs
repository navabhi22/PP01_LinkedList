using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList");
            LinkedList<int> list =new LinkedList<int>();
            list.AddLast(56);
            list.AddLast(30);
            list.AddLast(70);

            foreach (var ele in list)
            {
                Console.WriteLine(ele);
            }
        }
    }
}