using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    class Program
    {
        static void Main(string[] args)
        {
            Nelinurk nurk = new Nelinurk(3, 3);
            nurk.Info();
            nurk.DiagonaalInfo();
            Console.ReadKey();
        }
    }
}
