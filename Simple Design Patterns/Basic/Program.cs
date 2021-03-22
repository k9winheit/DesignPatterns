using System;
using System.Collections.Generic;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {           
            List<Object> listObjs = new List<object>();
            listObjs.Add(1);
            listObjs.Add("Kanishka");
            listObjs.Add(true);
            listObjs.Add(new object());
            listObjs.ForEach(el =>
            {
                Console.WriteLine("-----");
                Console.WriteLine(el);
            });
            Console.ReadLine();
        }
    }
}
