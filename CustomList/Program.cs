using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)

        {
            List<string> foo = new List<string>();
            foo.Add("hjhjhj");
            Console.WriteLine(foo.Count);
        }
        CustomList<string> ListTest = new CustomList<string>();
    }
}
