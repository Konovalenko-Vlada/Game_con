using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication143
{
    class Game
    {
        // public List<Coordinate> Coords = new List<Coordinate>();
        public int[ , ] Val;
        int c = 0;

        public Game(params int[] data)
        {
            int size = Convert.ToInt32(Math.Sqrt(data.Length));

            if (size % 1 != 0)
            {
                throw new ArgumentException("Error Size!!!");
            }

            Val = new int[size, size];

            /*
            for (int i = 1; i <= data.Length; i++ )
            {
                Coords.Add(new Coordinate());
            }
            */

            //int index = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    //Coords[index].x = i + 1;
                    //Coords[index].y = j + 1;
                    //Coords[index].filled = true;
                    //index++;

                    this.Val[i, j] = c++;
                }
            }
        }

        public Game(params string[] data)
        {
            if (Math.Sqrt(data.Length) % 1 != 0)
            {
                throw new ArgumentException("Error Size!!!");
            }

            for (int i = 0; i < Math.Sqrt(data.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(data.Length); j++)
                {
                    //Coordinate temp_Coordinate = new Coordinate();
                    //temp_Coordinate.x = i++;
                    //temp_Coordinate.y = j++;
                    //Coords[Convert.ToInt32(data[i + j])] = temp_Coordinate;

                    this.Val[i, j] = c++;
                }
            }
        }

        public int this[int x, int y]
        {
            get
            {
                //return Coords.FindIndex(coord => (coord.x == x) && (coord.y == y));
                return this.Val[x, y];
            }

            set
            {
                this.Val[x, y] = value;
            }
        }

        public Coordinate GetLocation(int value)
        {
            Coordinate tempCoord = new Coordinate();

            for (int i = 0; i < Math.Sqrt(this.Val.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(this.Val.Length); j++)
                {
                    if (this.Val[i, j] == value)
                    {
                        tempCoord.x = i;
                        tempCoord.y = j;
                        tempCoord.filled = true;
                    }
                }
            }
            return tempCoord;
        }

        public virtual void Shift(int value)
        {
            Coordinate zero = this.GetLocation(0);
            Coordinate val = this.GetLocation(value);

            if (Math.Abs(zero.x - val.x) == 1 || Math.Abs(zero.y - val.y) == 1)
            {
                Coordinate prom = zero;
                zero = val;
                val = prom;

                this[val.x, val.y]
            }
            else
            {
                throw new ArgumentException("Error no empty space!!!");
            }
        }

        public static Game FromCSV(string file)
        {
            string[] data = File.ReadAllText(file).Split(';');
            return new Game(data);
        }
    }
}

