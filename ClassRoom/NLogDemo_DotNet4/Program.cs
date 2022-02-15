using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo_DotNet4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AddNumbers obj = new AddNumbers();
            obj.Sum(3, 5);
            obj.Sum(0, 5);
        }
    }
}
