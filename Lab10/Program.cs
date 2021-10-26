using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle ang = new Angle();
            ang.Gradus = 100;
            ang.Min = 40;
            ang.Sec = 30;
            ang.ToRadians();
            Console.ReadKey();
        }
    }
    class Angle
    {
        private int gradus;
        private int min;
        private int sec;
        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
            }
        }

        public int Min
        {
            set
            {
                if (value < 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Необходимо ввести меньше 60 минут");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value < 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Необходимо ввести меньше 60 секунд");
                }
            }
            get
            {
                return sec;
            }
        }
        public double ToRadians()
        {
            double rad = (((Math.PI) * gradus) / 180) + ((Math.PI) * (min) / (180 * 60)) + (((Math.PI) * sec) / (3600 * 180));
            Console.WriteLine(rad);
            return rad;
        }
    }
}
