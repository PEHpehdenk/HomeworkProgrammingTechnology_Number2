using System.Text;
using System.Text.RegularExpressions;

public class Laboratory_Tumakov_Number3
{
    public enum bankAccountType : int {
        actual,
        safe
    }

    public enum ВУЗ
    {
        КГУ,
        КАИ,
        КХТИ
    }

    public class BankUserAccount
    {
        public int id;
        public bankAccountType typeOfBill;
        public int balance;
        public BankUserAccount(int user_id, bankAccountType user_typeOfBill, int user_balance)
        {
            id = user_id;
            typeOfBill = user_typeOfBill;
            balance = user_balance;
        }
    }

    public class BankWorker
    {
        public string name;
        public ВУЗ university;
        public BankWorker(string user_name, ВУЗ user_university)
        {
            name = user_name;
            university = user_university;
        }
    }
    public static void exersice_3_1()
    {
        Console.WriteLine("Упражнение 3.1. Создать перечисляемую переменную и вывести её значение");
        bankAccountType userBankAccountSafe = bankAccountType.safe;
        Console.WriteLine($"Тип счёта: {userBankAccountSafe}");
    }
    public static void exersice_3_2()
    {
        Console.WriteLine("Упражнение 3.1. Создать структуру данных, хранящую данные о счёте в банке, заполнить значения и вывести их");
        bankAccountType userBankAccountSafe = bankAccountType.actual;
        BankUserAccount user = new BankUserAccount(10, userBankAccountSafe, 1000);
        Console.WriteLine($"Номер счёта: {user.id}");
        Console.WriteLine($"Тип счёта: {user.typeOfBill}");
        Console.WriteLine($"Баланс: {user.balance}");
    }
    public static void homework_3_1()
    {
        Console.WriteLine("Домашняя работа 3.1. Создать структуру работника банка, заполнить значениями и вывести их");
        ВУЗ workersUniversity = ВУЗ.КХТИ;
        BankWorker worker = new BankWorker("Владимир", workersUniversity);
        Console.WriteLine($"Имя: {worker.name}");
        Console.WriteLine($"ВУЗ: {worker.university}");
    }
    public static void Main()
    {
        exersice_3_1();
        exersice_3_2();
        homework_3_1();
    }
}