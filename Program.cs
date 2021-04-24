using System;

namespace ทำข้อสอบ4
{
    class Program
    {
        static void Main(string[] args)
        {
            float x,x1,x2, y,y1,y2, dx, dy, step;
            x1 = float.Parse(Console.ReadLine());
            y1 = float.Parse(Console.ReadLine());
            x2 = float.Parse(Console.ReadLine());
            y2 = float.Parse(Console.ReadLine());

            dx = x2 - x1;
            dy = y2 - y1;

            if(dx>=dy)
            {
                step = dx;
            }
            else if (dx<=dy)
            {
                step=dy;
            }
            dx /= step;
            dy /= step;
            x = x1;
            y = y1;

            int i = 1;
            do
            {
                    Console.WriteLine(x, ",", y);
                x += dx;
                y += dy;
                i++;
            } while (i <= step);

        }
    }
}
