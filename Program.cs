using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball(16000, 700);

            var e = ball.BallValidatable();

            if (e.Count != 0)
            {
                foreach (var er in e)
                {
                    Console.WriteLine(er);
                }
            }
            else
            {
                Console.WriteLine("Мяч прошел проверку");
            }
            Console.WriteLine("\n Следующий мяч");

            Ball ball2 = new Ball(150, 66);
            var e1 = ball2.BallValidatable();
            if (e1.Count != 0)
            {
                foreach (var er in e1)
                {
                    Console.WriteLine(er);
                }
            }
            else
            {
                Console.WriteLine("Мяч прошел проверку");
            }
        }
    }
    
}
