using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17
{
    // Создать класс для моделирования счета в банке.
    public class BankAccount<T>
    {
        T accountNumber;
        int balance;
        string firstName;
        string secondName;

        public BankAccount(T aN, int b, string fN, string sN)
        {
            accountNumber = aN;
            balance= b;
            firstName = fN;
            secondName = sN;
        }
        public void Get()
        {
            Console.WriteLine($"Номер счета = {accountNumber}, баланс = {balance}, Имя = {firstName}, Фамилия = {secondName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> accountNumber1 = new BankAccount<int>(123, 234, "Михаил", "Михайлов");
            BankAccount<string> accountNumber2 = new BankAccount<string>("123KF457", 456, "Иван", "Иванов");
            accountNumber1.Get();
            accountNumber2.Get();
            Console.ReadKey();
        }
    }
}
