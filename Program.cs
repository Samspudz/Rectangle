/* 
 * author: Adam Marshall
 * date: 02/19/2023
 * class: GAME-1343
 * project: Rectangle
 */

using System;

namespace Rectangle
{
    internal class Program
    {
        public static Random random;
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            random = new Random();

            Console.Write("Please enter a minimum number: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a maximum number: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int l = r.Length;
            int w = r.Width;


            MakeRectangle(min, max, out l, out w);

            int area = Utility.Area(l, w);
            int perimeter = Utility.Perimeter(l, w);

            Console.WriteLine("Length: " + l);
            Console.WriteLine("Width: " + w);
            Console.WriteLine("Area: " +  area);
            Console.WriteLine("Perimeter: " + perimeter);
            
        }
        static void MakeRectangle(int min, int max, out int l, out int w)
        {
            l = random.Next(min, max);
            w = random.Next(min, max);
        }
    }

    

    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle ()
        {
            length = 0;
            width = 0;
        }
        public Rectangle(int l, int w)
        {
            length = l; 
            width = w;
        }

        public int Length
        {
            get => length;
            set => length = value;
        }

        public int Width
        {
            get => width;
            set => width = value;
        }
    }

    public class Utility
    {
        public static int Area(int l, int w)
        {
            return l * w;
        }

        public static int Perimeter(int l, int w)
        {
            return 2 * (l + w);
        }
    }
}