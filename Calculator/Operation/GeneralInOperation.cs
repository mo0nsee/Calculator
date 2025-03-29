using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operation
{
    /// <summary>
    /// Общее в операциях
    /// </summary>
    abstract public class GeneralInOperation : IOperation
    {
        /// <summary>
        /// Первый параметр
        /// </summary>
        protected double _parametrsOne;
        /// <summary>
        /// Второй параметр
        /// </summary>
        protected double _parametrsTwo;

        public virtual double Operation()
        {
            throw new NotImplementedException();
        }

        public GeneralInOperation(double parametrsOne, double parametrsTwo)
        {
        }
    }
}
