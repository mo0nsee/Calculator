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
    public class AdditionTests
    {
        [TestMethod()]
        public void OperationTest()
        {
            double parametrOne = 5.1;
            double parametrTwo = 2.2;
            double expected = 7.3;

            Addition additionInstance = new Addition(parametrOne, parametrTwo);
            double actual = additionInstance.Operation();

            Assert.AreEqual(expected, actual, 0.001 , $"Сумма {parametrOne} и {parametrTwo} " +
                                                        $"должна быть {expected}, получилось {actual}");
        }
    }
}