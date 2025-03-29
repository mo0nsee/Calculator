using Calculator.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Подсчёт результата
    /// </summary>
    public class ResultСalculation
    {
        private Addition _addition;
        private Subtraction _subtraction;
        private Multiplication _multiplication;
        private Division _division;
        private RemainderOfDivision _remainderOfDivision;

        StringBuilder _inputStr;

        private string _resultStr;

        public string Result
        {
            get => _resultStr;
        }

        public ResultСalculation(string inputStr)
        {
            _inputStr = new StringBuilder(inputStr);
            ParsingInputStr();
        }

        /// <summary>
        /// 
        /// </summary>
        private void ParsingInputStr()
        {
            _inputStr.Replace(" ", "").Replace(",",".");
            Match match = Regex.Match(_inputStr.ToString(), @"([-+*/%])");
            if (match.Success)
            {
                int opIndex = match.Index;

                double left = Double.Parse(_inputStr.ToString().AsSpan(0, opIndex));
                ReadOnlySpan<char> op = _inputStr.ToString().AsSpan(opIndex, 1);
                double right = Double.Parse(_inputStr.ToString().AsSpan(opIndex + 1));

                _inputStr.Clear();
                switch (op[0])
                {
                    case '+':
                        _addition = new Addition(left, right);
                        _inputStr.Append(_addition.Operation());
                        break;
                    case '-':
                        _subtraction = new Subtraction(left, right);
                        _inputStr.Append(_subtraction.Operation());
                        break;
                    case '*':
                        _multiplication = new Multiplication(left, right);
                        _inputStr.Append(_multiplication.Operation());
                        break;
                    case '/':
                        _division = new Division(left, right);
                        _inputStr.Append(_division.Operation());
                        break;
                    case '%':
                        _remainderOfDivision = new RemainderOfDivision(left, right);
                        _inputStr.Append(_remainderOfDivision.Operation());
                        break;
                }
            }
            _resultStr = _inputStr.ToString();
        }
    }
}
