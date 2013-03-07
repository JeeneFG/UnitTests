using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestBox
{
    public class BoxParam
    {
        public static double GetVolume(Box box)
        {
            if (box == null)
            {
                throw new ArgumentException("Ссылка не указывает на объект");
            }

            return box.Length * box.Height * box.Width;
        }

        public double GetArea(Box box)
        {
            if (box == null)
            {
                throw new ArgumentException("Ссылка не указывает на объект");
            }

            return box.Length * box.Height * 2 + box.Height * box.Width * 2 + box.Length * box.Width * 2;
        }
    }
}
