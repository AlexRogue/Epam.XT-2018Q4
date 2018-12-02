using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2._7.VectorGraphicsEditor
{
    public class Context
    {
        int option;

        public Context(int option)
        {
            this.option = option;
        }


        public Creator GetFigure()
        {
            switch (option)
            {
                case 1:
                    return new LineCreator();
                
            }
            return null;
        }
    }
}
