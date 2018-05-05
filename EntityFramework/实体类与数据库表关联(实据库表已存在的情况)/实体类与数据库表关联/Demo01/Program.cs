using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            var data = context.Donators.ToList();
            Console.WriteLine(data.Count);
            Console.ReadLine();
        }
    }
}
