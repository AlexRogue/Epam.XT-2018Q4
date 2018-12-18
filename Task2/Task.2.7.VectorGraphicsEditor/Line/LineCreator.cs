using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2._7.VectorGraphicsEditor
{
    class LineCreator : Creator
    {
        public override IFigure ReturnConcreteFigure()
        {
            return new Line();
        }
    }
}
