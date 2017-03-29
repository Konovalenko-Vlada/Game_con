using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication143
{
    interface IPlayable 
    {
        void Random();
        void Shift(int value);
        bool Result { get; }
        public int this[int x, int y] { get; set; }
    }
}
