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
    public class RemainderOfDivisionTests
    {
        [TestMethod()]
        public void OperationTest()
        {
            double parametrOne = 5.1;
            double parametrTwo = 2.2;
            double expected = 0.7;

            RemainderOfDivision remainderOfDivisionInstance = new RemainderOfDivision(parametrOne, parametrTwo);
            double actual = remainderOfDivisionInstance.Operation();

            Assert.AreEqual(expected, actual, 0.001, $"Остаток от деления {parametrOne} и {parametrTwo}" +
                                                        $" должен быть {expected}, получилось {actual}");
        }
    }
}