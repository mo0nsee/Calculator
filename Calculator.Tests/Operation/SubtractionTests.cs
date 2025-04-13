using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operation.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        [TestMethod()]
        public void OperationTest()
        {
            double parametrOne = 5.1;
            double parametrTwo = 2.2;
            double expected = 2.9;

            Subtraction subtractionInstance = new Subtraction(parametrOne, parametrTwo);
            double actual = subtractionInstance.Operation();

            Assert.AreEqual(expected, actual, 0.001, $"Вычитание {parametrTwo} из {parametrOne} " +
                                                        $"должно быть {expected}, получилось {actual}");
        }
    }
}