using System;

namespace boxProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of the class box.cs

            //box box = new box();

            //assign the values to the object
            //box.Height = -3;
            //box.length = 3;
            ///box.SetLength(4);
            //box.Width = 14;
            box box = new box(3, 4, 5);
            Console.WriteLine("Box length is " + box.GetLength() + " and the volume is " + box.GetVolume());
            Console.WriteLine("Box width is " + box.Width);
            box.DisplayInfo();
            Console.WriteLine("Front surface is {0}", box.FrontSurface);
        }
    }
}
