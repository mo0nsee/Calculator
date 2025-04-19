using Calculator;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Соединение с бд
    /// </summary>
    public class ConnectionDB : DbContext
    {
        private static ConnectionDB instance;
        /// <summary>
        /// Создание экземпляра
        /// </summary>
        /// <returns></returns>
        public static ConnectionDB getInstance()
        {
            if (instance == null)
                instance = new ConnectionDB();
            return instance;
        }

        /// <summary>
        /// Получение таблицы со операциями калькулятора
        /// </summary>
        public DbSet<ResultCalculation> ResultCalculations => Set<ResultCalculation>();

        //Создание базы данных
        public ConnectionDB() => Database.EnsureCreated();

        public void Close()
        {
            Database.CloseConnection();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-5DQNS6K\SQLEXPRESS;Database=CalculationBD;Trusted_Connection=True; Encrypt=False");
        }
    }
}
