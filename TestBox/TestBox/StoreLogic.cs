using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestBox
{
    public class StoreLogic
    {
        public List<Box> Sort(Store store)
        {
            if (store == null)
            {
                throw new ArgumentException("Ссылка не указывает на объект");
            }

            List<Box> boxes = store.Boxes;

            boxes.Sort((o1, o2) =>
                {
                    /*BoxParam param = new BoxParam();*/
                    double firstVolume = BoxParam.GetVolume(o1);
                    double secondVolume = BoxParam.GetVolume(o2);

                    return firstVolume.CompareTo(secondVolume);
                });

            return boxes;
        }
    }
}
