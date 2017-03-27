using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication143
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleGameUI g1 = new ConsoleGameUI();
            g1.RedrawConsole();
            g1.Play();
        }
    }
}
