using System;

namespace boxProgram
{
    public class box
    {
        private int length = 3;
        public int height;
        public int width;
        public int volume;

        //creating a method to set a variable
        //changing the public to private will not allow outside programs to set the length
        public void SetLength(int length) 
        {
            this.length = length;
        }
        //Creating a getter...which will return the input
        public int GetLength() 
        {
            return this.length;
        }

        public int GetVolume ()
        {
            return this.length * this.height * this.width;
        }
        public void DisplayInfo() {
            Console.WriteLine("Length is {0}, heigth is {1} width is {2}.  Volume is {3}.", length, height, width, volume = height * width * length);
        }
        
    }
}