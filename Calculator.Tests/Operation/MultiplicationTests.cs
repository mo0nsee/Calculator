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
    public class MultiplicationTests
    {
        [TestMethod()]
        public void OperationTest()
        {
            double parametrOne = 5.1;
            double parametrTwo = 2.2;
            double expected = 11.22;

            Multiplication multiplicationInstance = new Multiplication(parametrOne, parametrTwo);
            double actual = multiplicationInstance.Operation();

            Assert.AreEqual(expected, actual, 0.001, $"Результат умножения {parametrOne} и {parametrTwo}" +
                                                        $" должен быть {expected}, получилось {actual}");
        }
    }
}