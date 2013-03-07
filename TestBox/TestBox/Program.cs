using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(4, 2, 2);
            Console.WriteLine(box);
          
            Console.WriteLine(BoxParam.GetVolume(box));
            Console.ReadKey();
        }
    }
}
