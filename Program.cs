﻿using System;
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
            Node node = new Node(56);
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine(" ");
            int a = list.Search(30);
            list.InsertaAtaParticularPosition(a+1, 40);
            list.Display();
            

        }

    }
}