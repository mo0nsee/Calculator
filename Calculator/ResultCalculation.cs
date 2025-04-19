using Calculator.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Подсчёт результата
    /// </summary>
    public class ResultCalculation
    {
        private int _id; // id
        private DateTime _date = DateTime.Now; // дата, когда выражение было подсчитано
        private StringBuilder _inputStr; // входная строка
        private string _resultStr; // результат

        private Addition _addition; // Класс суммирования
        private Subtraction _subtraction; // Класс вычитания
        private Multiplication _multiplication; // Класс умножения
        private Division _division; // Класс деления
        private RemainderOfDivision _remainderOfDivision; // Класс деления с отстатком

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        /// <summary>
        /// Входное выражение
        /// </summary>
        public string InputExpression
        {
            get => _inputStr.ToString();
            set => _inputStr = new StringBuilder(value);
        }

        /// <summary>
        /// Результат
        /// </summary>
        public string Result
        {
            get => _resultStr;
            set => _resultStr = value;
        }

        /// <summary>
        /// Дата, когда выражение было посчитано
        /// </summary>
        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        public ResultCalculation(string inputStr)
        {
            if (inputStr == string.Empty)
                _inputStr = new StringBuilder("");
            else
            {
                _inputStr = new StringBuilder(inputStr);
                ParsingInputStr();
            }
        }
        public ResultCalculation()
        {
        }

        /// <summary>
        /// Запись результата
        /// </summary>
        private void ParsingInputStr()
        {
            double result = ParseExpression(_inputStr.ToString());
            //_inputStr.Clear();
            //_inputStr.Append(result.ToString());
            _resultStr = result.ToString();
        }

        /// <summary>
        /// Рекурсивный парсер строки 
        /// </summary>
        private double ParseExpression(string str)
        {
            str.Replace(" ", "").Replace(",", ".");

            // Удаляем внешние скобки
            while (str.StartsWith("(") && str.EndsWith(")") && ParenthesisCheck(str.Substring(1, str.Length - 2)))
                str = str.Substring(1, str.Length - 2);

            char op = '\0';

            // Находим оператор с наименьшим приоритетом
            int opIndex = SearchOperator(str, ref op);
            if (opIndex != -1)
            {
                string leftExpr = str.Substring(0, opIndex);
                string rightExpr = str.Substring(opIndex + 1);

                double left = ParseExpression(leftExpr);  // Рекурсивный вызов для левой части
                double right = ParseExpression(rightExpr);  // Рекурсивный вызов для правой части

                switch (op)
                {
                    case '+':
                        _addition = new Addition(left, right);
                        return _addition.Operation();
                    case '-':
                        _subtraction = new Subtraction(left, right);
                        return _subtraction.Operation();
                    case '*':
                        _multiplication = new Multiplication(left, right);
                        return _multiplication.Operation();
                    case '/':
                        _division = new Division(left, right);
                        return _division.Operation();
                    case '%':
                        _remainderOfDivision = new RemainderOfDivision(left, right);
                        return _remainderOfDivision.Operation();
                }
            }

            return double.Parse(str);
        }

        /// <summary>
        /// Находим последний оператор c наименьшей ценностью вне скобок
        /// </summary>
        private int SearchOperator(string str, ref char @operator)
        {
            int depth = 0;
            int minPrecedence = int.MaxValue;
            int opIndex = -1;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(') 
                    depth++;
                else if (str[i] == ')') 
                    depth--;
                else if (depth == 0 && "+-*/%".Contains(str[i]))//Ищем операторы вне скобок
                {
                    int prec = OperatorValue(str[i]);
                    if (prec <= minPrecedence)  //Находим оператор с наименьшей ценностью
                    {
                        minPrecedence = prec;
                        @operator = str[i];
                        opIndex = i;
                    }
                }
            }
            return opIndex;
        }

        /// <summary>
        /// Проверка скобок
        /// </summary>
        private bool ParenthesisCheck(string str)
        {
            int depth = 0;
            foreach (char c in str)
            {
                if (c == '(')
                    depth++;
                else if (c == ')')
                    depth--;
            }
            return depth == 0;
        }

        /// <summary>
        /// Ценность оператора
        /// </summary>
        private int OperatorValue(char op)
        {
            switch (op)
            {
                case '+' or '-':
                    return 1;
                case '*' or '/' or '%':
                    return 2;
                default:
                    return int.MaxValue;
            }
        }
    }
}
