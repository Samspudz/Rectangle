using System.ComponentModel.DataAnnotations;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Rectangle
    {
        private int length;
        private int height;

        public int Length
        {
            get => length;
            set => length = value;
        }

        public int Height
        {
            get => height;
            set => height = value;
        }
    }

    public class Utility
    {
        static void Area(Rectangle rect) 
        {

        }

        static void Perimiter(Rectangle rect)
        {

        }
    }
}