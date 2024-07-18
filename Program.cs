using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vars_uygulama_
{
    class Program
    {
        static void Main(string[] args)
        {
            //var x = 23; // Implicitly typed.
            // int y = 23; // Explicitly typed.

            string[] meyveler = { "elma", "armut", "muz", "üzüm", "şeftali" };

            var meyve = from m in meyveler
                        where m[0] == 'a'
                        select m;
            foreach (string m in meyve)
            Console.WriteLine(m);
        }
    }
}
