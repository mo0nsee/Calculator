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
    public class DivisionTests
    {
        [TestMethod()]
        public void OperationTest()
        {
            double parametrOne = 5.1;
            double parametrTwo = 2.2;
            double expected = 2.318;

            Division divisionInstance = new Division(parametrOne, parametrTwo);
            double actual = divisionInstance.Operation();

            Assert.AreEqual(expected, actual, 0.001, $"Результат деления {parametrOne} и {parametrTwo}" +
                                                        $" должен быть {expected}, получилось {actual}");
        }
    }
}