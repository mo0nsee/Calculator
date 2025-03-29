using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operation
{
    /// <summary>
    /// Вычитание
    /// </summary>
    public class Subtraction : GeneralInOperation
    {
        public Subtraction(double parametrsOne, double parametrsTwo) : base(parametrsOne, parametrsTwo)
        {
            _parametrsOne = parametrsOne;
            _parametrsTwo = parametrsTwo;
        }

        override public double Operation()
        {
            return _parametrsOne - _parametrsTwo;
        }
    }
}
