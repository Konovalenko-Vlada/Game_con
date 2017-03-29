using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication143
{
    class ConsoleGameUI
    {
        public IPlayable Obj;
        public int Count;
        public ConsoleGameUI()
        {
            Console.WriteLine("Сколько цифр в игре?");
            Count = Convert.ToInt32(Console.ReadLine());

            if (Math.Sqrt(Count) % 1 != 0)
            {
                Console.WriteLine("Нет такого поля! ХР");
                Environment.Exit(1);
            }

            int[] mas = new int[Count];
            for (int i = 0; i < Count; i++)
            {
                mas[i] = i;
            }          
            Obj = new Game3(mas);////?????
        }

        public void RedrawConsole()
        {
            for (int i = 0; i < Math.Sqrt(Count); i++)
            {
                string str = "";
                for (int j = 0; j < Math.Sqrt(Count); j++)
                {
                    str += Convert.ToString(Obj[i, j]); 
                    str += " ";
                }
                Console.WriteLine(str);
            }
        }

        public void Play()
        {
            //this.MakeStep();
            while (!Obj.Result)
            {
                this.MakeStep();
            } 
        }

        public void MakeStep()
        {
            int puzzle = 0;
            Console.WriteLine("Какую цифру Вы хотите передвинуть?");
            puzzle = Convert.ToInt32(Console.ReadLine());
            if (puzzle > this.Count)
            {
                Console.WriteLine("Такой цифры нету в игре!");
            }
            else
            {
                Obj.Shift(puzzle);
                this.RedrawConsole();
            }
        }
    }
}
