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
        Creator creator;


        public Context()
        {
            ReciveOption();
        }


        private void ReciveOption()
        {
            do
            {
                int.TryParse(Console.ReadLine(), out option);
                if (option > 5 | option < 1)
                {
                    Console.WriteLine("Enter right option");
                }
            } while (option > 5 | option < 1);
        }


        public Creator GetFigure()
        {
            switch (option)
            {
                case 1:
                    creator = new LineCreator();
                    break;
                case 2:
                    creator = new CircleCreator();
                    break;
                case 3:
                    creator = new RectangleCreator();
                    break;
                case 4:
                    creator = new RoundCreator();
                    break;
                case 5:
                    creator = new RingCreator();
                    break;
            }

            return creator;
        }
    }
}
