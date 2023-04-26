using System;
using System.Collections.Generic;

namespace LinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            linkedList list = new linkedList();
            list.AddFirst(70);
            list.AddFirst(30);
            list.AddFirst(56);
            list.Display();
        }
    }
}
