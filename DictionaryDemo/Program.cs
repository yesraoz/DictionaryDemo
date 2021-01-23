using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> name = new MyDictionary<int, string>();
            name.Add(1, "Esra");
            name.Add(2, "Yaðmur");
            name.Add(3, "Seminay");
            name.Add(4, "Batuhan");
         


            Console.WriteLine(name.Count);


            foreach (var item in name.value)
            {
                Console.WriteLine(item);
            }
            foreach (var item in name.keys)
            {
                Console.WriteLine(item);
            }

        }
    }
}
