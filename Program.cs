using System;

namespace boxProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of the class box.cs

            box box = new box();

            //assign the values to the object
            box.height = 1;
            //box.length = 3;
            box.SetLength(4);
            box.width = 4;
            Console.WriteLine("Box length is " + box.GetLength() + " and the volume is " + box.GetVolume());
            box.DisplayInfo();
        }
    }
}
