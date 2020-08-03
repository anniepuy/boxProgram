using System;

namespace boxProgram
{
    public class box
    {
        //Created member varialbes 
        //made them private which requires new properties to access such as set and get.
        private int length = 3;
        public int height;
        public int width;
        public int volume;

        //another way to create a property
        //prop tab
        public int Width { get; set; }

        //another way to create a set and get below..but shorter
        public int Height 
        {
            get
            {
                return height;
            }
            set
            {
                if(value < 0 )
                {
                    System.Console.WriteLine("Please enter in a correct value for heigth");
                }
                else
                {
                height = value;
                }
            }
        }

//user properties must have capital Letter "Volume"  use either get or set
        public int Volume 
        {
            get{
                return volume;
            }
            set
            {
                this.volume = value;
            }
        }

        // create a constuctor
        public box(int lenth, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }

        //creating a property to set a variable
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

        //new property to caluclate a surface
        public int FrontSurface 
        {
            get { return height * length;}
        }
        public void DisplayInfo() {
            Console.WriteLine("Length is {0}, heigth is {1} width is {2}.  Volume is {3}.", length, height, width, volume = height * width * length);
        }
        
    }
}