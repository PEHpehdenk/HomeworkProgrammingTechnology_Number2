using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static HomeworkProgrammingTechnology_Number2;

public class HomeworkProgrammingTechnology_Number2
{
    public class UserFromTask2
    {
        public string name;
        public string city;
        public int age;
        public int PIN_code;
        public UserFromTask2(string user_name, string user_city, int user_age, int user_PIN_code) {
            name = user_name;
            city = user_city;
            age = user_age;
            PIN_code = user_PIN_code;
        }
    }

    public class Student
    {
        public string surname;
        public string name;
        public string id;
        public string dateOfBirthday;
        public string alchogolicCategory;
        public int voluemOfDrankAlchogol;
        public Student(string student_surname, string student_name, string student_id, string student_dateOfBirthday, string student_alchogolicCategory, int student_VoluemOfDrankAlchogol)
        {
            surname = student_surname;
            name = student_name;
            id = student_id;
            dateOfBirthday = student_dateOfBirthday;
            alchogolicCategory = student_alchogolicCategory;
            voluemOfDrankAlchogol = student_VoluemOfDrankAlchogol;
        }
        public void StudentInformation(int students_summaryVoluemOfDrankAlchogol)
        {
            Console.WriteLine($"Информация о студенте {id}:\n" +
            $"Фамилия: {surname}\n" +
            $"Имя: {name}\n" +
            $"Индификатор: {id}\n" +
            $"Дата рождения: {dateOfBirthday}\n" +
            $"Категория алкоголизма: {alchogolicCategory}\n" +
            $"Объём выпитого алкоголя в литрах: {voluemOfDrankAlchogol}\n" +
            $"Объём выпитого алкоголя в процентах: {Math.Round((Convert.ToDouble(voluemOfDrankAlchogol) / students_summaryVoluemOfDrankAlchogol) * 100)}%");
        }
    }

    public static void markup()
    {
        Console.Write("\n-------------------------------------------------------\n");
    }

    public static bool isCorrectData()
    {
        bool isCorrectRequare = false;
        while (!isCorrectRequare) {
            Console.WriteLine("Если вы хотите оставить эти данные - введите 1, иначе 0");
            string answerOfUser = Console.ReadLine();
            if (answerOfUser == "0")
            {
                isCorrectRequare = true;
                return false;
            }
            if (answerOfUser == "1")
            {
                isCorrectRequare = true;
                return true;
            }
            Console.WriteLine("ОШИБКА: Введённые данные не соответствуют требуемому формату.");
        }
        return false;
    }

    public static void realisticWrite(string sentenceToWrite, int timeToSleep_ms)
    {
        foreach (char charElement in sentenceToWrite)
        {
            Console.Write(charElement);
            System.Threading.Thread.Sleep(timeToSleep_ms);
        }
        Console.WriteLine();
    }
    public static void task1()
    {
        Console.Write("\nЗадача 1\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("В данной задаче необходимо выввести информацию о каждом типе данных (максимальное и минимальное значение).");
        Console.WriteLine("\nРЕАЛИЗАЦИЯ:\n");
        Type[] types = typeof(Type).Assembly.GetTypes();
        bool isRequestCorrect = false;
        bool isPrimitiveForm = false;
        while (!isRequestCorrect)
        {
            Console.WriteLine("Для информации о всех типов данных введите 0 (В данном случае у непримитивных типов данных отсутствуют максимальное и минимальное значения. Для информации только о примитивных типах данных введите 1");
            try
            {
                isPrimitiveForm = Convert.ToBoolean(Convert.ToInt16(Console.ReadLine()));
                isRequestCorrect = true;
            }
            catch
            {
                markup();
                Console.Write("\nОШИБКА: Введённые данные не соответствуют требуемому формату.\n");
                markup();
            }
        }
        foreach (Type type in types)
        {
            if (type.IsPrimitive)
            {
                Console.Write($"\nТип данных: {type.Name}\n");
                if (type.Equals(typeof(bool)))
                {
                    Console.WriteLine($"Минимальное значение: {false}");
                    Console.WriteLine($"Максимальное значение: {true}");
                }
                if (type.Equals(typeof(byte)))
                {
                    Console.WriteLine($"Минимальное значение: {byte.MinValue}");
                    Console.WriteLine($"Максимальное значение: {byte.MaxValue}");
                }
                if (type.Equals(typeof(char)))
                {
                    Console.WriteLine($"Минимальное значение: {char.MinValue}");
                    Console.WriteLine($"Максимальное значение: {char.MaxValue}");
                }
                if (type.Equals(typeof(sbyte)))
                {
                    Console.WriteLine($"Минимальное значение: {sbyte.MinValue}");
                    Console.WriteLine($"Максимальное значение: {sbyte.MaxValue}");
                }
                if (type.Equals(typeof(short)))
                {
                    Console.WriteLine($"Минимальное значение: {short.MinValue}");
                    Console.WriteLine($"Максимальное значение: {short.MaxValue}");
                }
                if (type.Equals(typeof(ushort)))
                {
                    Console.WriteLine($"Минимальное значение: {ushort.MinValue}");
                    Console.WriteLine($"Максимальное значение: {ushort.MaxValue}");
                }
                if (type.Equals(typeof(int)))
                {
                    Console.WriteLine($"Минимальное значение: {int.MinValue}");
                    Console.WriteLine($"Максимальное значение: {int.MaxValue}");
                }
                if (type.Equals(typeof(uint)))
                {
                    Console.WriteLine($"Минимальное значение: {uint.MinValue}");
                    Console.WriteLine($"Максимальное значение: {uint.MaxValue}");
                }
                if (type.Equals(typeof(IntPtr)))
                {
                    Console.WriteLine("На 32-битной операционной системе");
                    Console.WriteLine($"Минимальное значение: {Int32.MinValue}");
                    Console.WriteLine($"Максимальное значение: {Int32.MaxValue}");
                    Console.WriteLine("На 64-битной операционной системе");
                    Console.WriteLine($"Минимальное значение: {Int64.MinValue}");
                    Console.WriteLine($"Максимальное значение: {Int64.MaxValue}");
                    Console.WriteLine("На вашей операционной системе");
                    Console.WriteLine($"Минимальное значение: {IntPtr.MinValue}");
                    Console.WriteLine($"Максимальное значение: {IntPtr.MaxValue}");
                }
                if (type.Equals(typeof(Single)))
                {
                    Console.WriteLine($"Минимальное значение: {Single.MinValue}");
                    Console.WriteLine($"Максимальное значение: {Single.MaxValue}");
                }
                if (type.Equals(typeof(long)))
                {
                    Console.WriteLine($"Минимальное значение: {long.MinValue}");
                    Console.WriteLine($"Максимальное значение: {long.MaxValue}");
                }
                if (type.Equals(typeof(ulong)))
                {
                    Console.WriteLine($"Минимальное значение: {ulong.MinValue}");
                    Console.WriteLine($"Максимальное значение: {ulong.MaxValue}");
                }
                if (type.Equals(typeof(double)))
                {
                    Console.WriteLine($"Минимальное значение: {double.MinValue}");
                    Console.WriteLine($"Максимальное значение: {double.MaxValue}");
                }
                if (type.Equals(typeof(UIntPtr)))
                {
                    Console.WriteLine("На 32-битной операционной системе");
                    Console.WriteLine($"Минимальное значение: {UInt32.MinValue}");
                    Console.WriteLine($"Максимальное значение: {UInt32.MaxValue}");
                    Console.WriteLine("На 64-битной операционной системе");
                    Console.WriteLine($"Минимальное значение: {UInt64.MinValue}");
                    Console.WriteLine($"Максимальное значение: {UInt64.MaxValue}");
                    Console.WriteLine("На вашей операционной системе");
                    Console.WriteLine($"Минимальное значение: {UIntPtr.MinValue}");
                    Console.WriteLine($"Максимальное значение: {UIntPtr.MaxValue}");
                }
            } 
            else
            {
                if (!isPrimitiveForm)
                {
                    Console.Write($"\nТип данных: {type.Name}\n");
                    Console.WriteLine("Тип данных не является примитивным");
                }
            }
        }
        Console.Write("\nВыполнение задачи завершено.\n");
    }

    public static void task2()
    {
        Console.Write("\nЗадача 2\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("В данной задаче необходимо считать данные пользователя (PIN-код; город; возраст; имя) и обработать их.");
        Console.WriteLine("\nРЕАЛИЗАЦИЯ:\n");
        bool isCorrectName = false;
        bool isCorrectCity = false;
        bool isCorrectAge = false;
        bool isCorrectPIN_code = false;
        string userName = "";
        string userCity = "";
        int userAge = 0;
        int userPIN_code = 0;
        while (!isCorrectName)
        {
            Console.WriteLine("Введите ваше имя (имя не должно содержать цифр и специальных символов):");
            try
            {
                userName = Console.ReadLine();
                bool isDigitInName = false;
                bool isSpecialElementInName = false;
                foreach (char charElement in userName)
                {
                    if (Char.IsDigit(charElement))
                    {
                        isDigitInName = true;
                        break;
                    }
                    if (!Char.IsLetter(charElement) && charElement != ' ')
                    {
                        isSpecialElementInName = true;
                        break;
                    }
                }
                if (!(isDigitInName || isSpecialElementInName || string.IsNullOrEmpty(userName)))
                {
                    Console.WriteLine($"Ваше имя: {userName}");
                    if (isCorrectData())
                    {
                        isCorrectName = true;
                    }
                } else
                {
                    Console.WriteLine("\nОШИБКА: Имя не должно содержать цифр и специальных символов.\n");
                }
            }
            catch
            {
                Console.WriteLine("\nОШИБКА: Введённые данные не соответствуют требуемому формату.\n");
            }
        }
        userName = char.ToUpper(userName[0]) + userName.Substring(1);
        while (!isCorrectCity)
        {
            Console.WriteLine("Введите ваш город (название города не должно содержать цифр и специальных символов):");
            try
            {
                userCity = Console.ReadLine();
                bool isDigitInCity = false;
                bool isSpecialElementInCity = false;
                foreach (char charElement in userCity)
                {
                    if (Char.IsDigit(charElement))
                    {
                        isDigitInCity = true;
                        break;
                    }
                    if (!Char.IsLetter(charElement) && charElement != ' ')
                    {
                        isSpecialElementInCity = true;
                        break;
                    }
                }
                if (!(isDigitInCity || isSpecialElementInCity || string.IsNullOrEmpty(userCity)))
                {
                    Console.WriteLine($"Ваш город: {userCity}");
                    if (isCorrectData())
                    {
                        isCorrectCity = true;
                    }
                }
                else
                {
                    Console.WriteLine("\nОШИБКА: Название города не должно содержать цифр и специальных символов.\n");
                }
            }
            catch
            {
                Console.WriteLine("\nОШИБКА: Введённые данные не соответствуют требуемому формату.\n");
            }
        }
        userCity = char.ToUpper(userCity[0]) + userCity.Substring(1);
        while (!isCorrectAge)
        {
            Console.WriteLine("Введите ваш возраст (приложение разработана для аудитории от 0 до 100 лет включительно):");
            try
            {
                userAge = Int32.Parse(Console.ReadLine());
                if (userAge < 0 || userAge > 100)
                {
                    Console.WriteLine("\nОШИБКА: Ваш возраст не входит в диапазон от 0 до 100 лет.\n");
                    continue;
                }
                Console.WriteLine($"Ваш возраст: {userAge}");
                if (isCorrectData())
                {
                    isCorrectAge = true;
                }
            }
            catch
            {
                Console.WriteLine("\nОШИБКА: Введённые данные не соответствуют требуемому формату.\n");
            }
        }
        while (!isCorrectPIN_code)
        {
            Console.WriteLine("Введите ваш PIN-код (PIN-код представляет собой четырехзначный код):");
            try
            {
                userPIN_code = Int32.Parse(Console.ReadLine());
                if (userPIN_code < 0 || userPIN_code > 9999)
                {
                    Console.WriteLine("\nОШИБКА: Ваш PIN-код не входит в выше указанные границы.\n");
                    continue;
                }
                Console.WriteLine($"Ваш PIN-код: {userPIN_code.ToString("D4")}");
                if (isCorrectData())
                {
                    isCorrectPIN_code = true;
                }
            }
            catch
            {
                Console.WriteLine("\nОШИБКА: Введённые данные не соответствуют требуемому формату.\n");
            }
        }
        UserFromTask2 user = new UserFromTask2(userName, userCity, userAge, userPIN_code);
        Console.Write($"\nИмя пользователя: {user.name}\n");
        Console.WriteLine($"Город пользователя: {user.city}");
        Console.WriteLine($"Возвраст пользователя: {user.age}");
        Console.WriteLine($"PIN-код пользователя: {user.PIN_code.ToString("D4")}");
        Console.Write("\nВыполнение задачи завершено.\n");
    }

    public static void task3()
    {
        Console.Write("\nЗадача 3\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("Дана строка, поменять регистр букв в данной строке");
        Console.WriteLine("\nРЕАЛИЗАЦИЯ:\n");
        Console.WriteLine("Введите строку:");
        StringBuilder sentence = new StringBuilder(Console.ReadLine());
        for (int indexOfChar = 0; indexOfChar < sentence.Length; indexOfChar++)
        {
            if (sentence[indexOfChar] == Char.ToUpper(sentence[indexOfChar]))
            {
                sentence[indexOfChar] = Char.ToLower(sentence[indexOfChar]);
            }
            else
            {
                sentence[indexOfChar] = Char.ToUpper(sentence[indexOfChar]);
            }
        }
        Console.Write($"\nНовая строка: {sentence}\n");
        Console.Write("\nВыполнение задачи завершено.\n");
    }

    public static void task4()
    {
        Console.Write("\nЗадача 4\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("Дана строка и подстрока. Найти вхождение подстроки в строку");
        Console.WriteLine("\nРЕАЛИЗАЦИЯ:\n");
        Console.WriteLine("Введите строку:");
        string sentence = Console.ReadLine();
        Console.WriteLine("Введите подстроку:");
        string subsentence = Console.ReadLine();
        Console.Write($"\nКоличество вхождений подстроки \"{subsentence}\" в строку \"{sentence}\": {Regex.Matches(sentence, subsentence).Count}\n");
        Console.Write("\nВыполнение задачи завершено.\n");
    }

    public static void task5()
    {
        Console.Write("\nЗадача 5\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("Дана стандартная цена бутылка виски, скидка в Duty Free и стоимость отпуска. Вывести, сколько бутылок виски беспошлинной торговли нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически покрыла расходы на отпуск.");
        Console.WriteLine("\nРЕАЛИЗАЦИЯ:\n");
        int priceOfBottle = 0;
        int discount = 0;
        int priceOfVacation = 0;
        bool isCorrectPriceOfBottle = false;
        while (!isCorrectPriceOfBottle) {
            Console.WriteLine("Введите стоимость бутылки виски (не меньше 0)");
            try
            {
                priceOfBottle = Int32.Parse(Console.ReadLine());
                if (priceOfBottle < 0)
                {
                    Console.WriteLine("\nОШИБКА: Стоимость бутылки должна быть не меньше 0\n");
                    continue;
                }
                isCorrectPriceOfBottle = true;
            }
            catch
            {
                Console.WriteLine("\nОШИБКА: Введённые данные не соответствуют требуемому формату.\n");
            }
        }
        bool isCorrectDiscount = false;
        while (!isCorrectDiscount)
        {
            Console.WriteLine("Введите размер скидки в процентах (в диапазоне от 0 до 100 включительно)");
            try
            {
                discount = Int32.Parse(Console.ReadLine());
                if (discount < 0 || discount > 100)
                {
                    Console.WriteLine("\nОШИБКА: Скидка не входит в диапазон от 0% до 100%\n");
                    continue;
                }
                isCorrectDiscount = true;
            }
            catch
            {
                Console.WriteLine("\nОШИБКА: Введённые данные не соответствуют требуемому формату.\n");
            }
        }
        bool isCorrectPriceOfVacation = false;
        while (!isCorrectPriceOfVacation)
        {
            Console.WriteLine("Введите стоимость отпуска (не меньше 0)");
            try
            {
                priceOfVacation = Int32.Parse(Console.ReadLine());
                if (priceOfVacation < 0)
                {
                    Console.WriteLine("\nОШИБКА: Стоимость отпуска должна быть не меньше 0\n");
                    continue;
                }
                isCorrectPriceOfVacation = true;
            }
            catch
            {
                Console.WriteLine("\nОШИБКА: Введённые данные не соответствуют требуемому формату.\n");
            }
        }
        if (discount > 0)
        {
            Console.Write($"\nВам понадобится купить {Math.Floor(priceOfVacation / (Convert.ToDouble(discount) / 100 * priceOfBottle))} бутылок, чтобы накопить на отпуска");
        }
        else
        {
            Console.Write("\nВы не сможете накопить на отпуск\n");
        }
        Console.Write("\nВыполнение задачи завершено.\n");
    }

    public static void task6()
    {
        Console.Write("\nЗадача 6\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("Воспроизведение разговора Гарри Поттера и дневника Тома Реддла.");
        Console.WriteLine("\nРЕАЛИЗАЦИЯ:\n");
        Console.WriteLine("Ваш сценарий, пожалуйста, не отходите от него:\n1) \"Привет\"\n2) *Введите ваше имя*\n3) \"Ты знаешь что-нибудь о тайной комнате?\"\n4) \"Можешь рассказать?\"\n");
        Console.WriteLine("Перед Вами дневник. Чтобы начать разговор - поздоровайтесь с дневником. После знакомства узнайте, знает ли книга что-то о тайной комнате\n");
        Random random = new Random();
        int timeToWait = 150;
        string helloString = Console.ReadLine();
        System.Threading.Thread.Sleep(random.Next(1500, 3500));
        realisticWrite("Как тебя зовут?", timeToWait);
        Console.WriteLine();
        string nameOfWriter = Console.ReadLine();
        System.Threading.Thread.Sleep(random.Next(1500, 3500));
        realisticWrite($"Привет, {nameOfWriter}", timeToWait);
        Console.WriteLine();
        string questionOfUser = Console.ReadLine();
        System.Threading.Thread.Sleep(random.Next(1500, 3500));
        realisticWrite($"Да", timeToWait);
        Console.WriteLine();
        string askOfUser = Console.ReadLine();
        System.Threading.Thread.Sleep(random.Next(1500, 3500));
        realisticWrite($"Нет", timeToWait);
        System.Threading.Thread.Sleep(5000);
        ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        int randomColor = random.Next(colors.Length - 1);
        Console.ForegroundColor = colors[randomColor];
        realisticWrite($"Но могу показать", timeToWait);
        Console.ResetColor();
        Console.Write("\nВыполнение задачи завершено.\n");
    }

    public static void task7()
    {
        Console.Write("\nЗадача 7\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("Вычисление контрольной цифры штрихкода (EAN13).");
        Console.WriteLine("\nРЕАЛИЗАЦИЯ:\n");
        Console.WriteLine("а) Цифры штрихкоды вычисляются рандомно");
        Random random = new Random();
        Int64 ean13 = 0;
        int sumOfOdd = 0;
        int sumOfEven = 0;
        int summary = 0;
        int controlDigit = 0;
        for (int randomNumberInd = 1; randomNumberInd <= 12; randomNumberInd++)
        {
            int randomNumber = random.Next(0, 9);
            ean13 = ean13 * 10 + randomNumber;
            if (randomNumberInd % 2 == 1)
            {
                sumOfOdd += randomNumber;
            }
            else
            {
                sumOfEven += randomNumber;
            }
        }
        sumOfEven *= 3;
        summary = sumOfOdd + sumOfEven;
        controlDigit = summary % 10;
        Console.WriteLine($"Контрольная цифра штрихкода \"{ean13.ToString("D12")}\": {(10 - controlDigit) % 10}");
        Console.WriteLine("b) Цифры штрихкоды задаются пользователем");
        ean13 = 0;
        sumOfOdd = 0;
        sumOfEven = 0;
        summary = 0;
        controlDigit = 0;
        bool isCorrectEan13 = false;
        while (!isCorrectEan13)
        {
            Console.WriteLine("Введите штрихкода (12-значное число)");
            try
            {
                ean13 = Convert.ToInt64(Console.ReadLine());
                if (ean13 < 100000000000 || ean13 > 999999999999)
                {
                    Console.WriteLine("\nОШИБКА: Длина штрихкода должна быть равна 12.\n");
                    continue;
                }
                isCorrectEan13 = true;
            }
            catch
            {
                Console.WriteLine("\nОШИБКА: Введённые данные не соответствуют требуемому формату.\n");
            }
        }
        for (int numberInd = 12; numberInd >= 1; numberInd--)
        {
            int number = ean13.ToString()[numberInd - 1] - '0';
            ean13 /= 10;
            if (numberInd % 2 == 1)
            {
                sumOfOdd += number;
            }
            else
            {
                sumOfEven += number;
            }
        }
        sumOfEven *= 3;
        summary = sumOfOdd + sumOfEven;
        controlDigit = summary % 10;
        Console.WriteLine($"Контрольная цифра штрихкода {ean13.ToString("D12")}: {(10 - controlDigit) % 10}");
        Console.Write("\nВыполнение задачи завершено.\n");
    }

    public static void task8()
    {
        Console.Write("\nЗадача 8\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("Создать класс студента, включащий в себя фамилию, имя, индификатор, дату рождения, категорию алкоголизма и объём выпитого алкоголя.");
        Console.WriteLine("\nРЕАЛИЗАЦИЯ:\n");
        Random random = new Random();
        Student student1 = new Student("Ерёвин", "Игорь", "009#5", "25.01.2005", "a", random.Next(1, 100));
        Student student2 = new Student("Камельман", "Саламон", "005#7", "13.08.2006", "c", random.Next(1, 100));
        Student student3 = new Student("Антонова", "Вера", "015#0", "01.03.2006", "d", 0);
        Student student4 = new Student("Волостнов", "Даниэль", "076#1", "25.09.2005", "b", random.Next(1, 100));
        Student student5 = new Student("Добрынина", "Валерия", "001#31", "30.03.2006", "a", random.Next(1, 100));
        int summaryVoluemOfDrankAlchogol = student1.voluemOfDrankAlchogol + student2.voluemOfDrankAlchogol + student3.voluemOfDrankAlchogol + student4.voluemOfDrankAlchogol + student5.voluemOfDrankAlchogol;
        student1.StudentInformation(summaryVoluemOfDrankAlchogol);
        Console.WriteLine();
        student2.StudentInformation(summaryVoluemOfDrankAlchogol);
        Console.WriteLine();
        student3.StudentInformation(summaryVoluemOfDrankAlchogol);
        Console.WriteLine();
        student4.StudentInformation(summaryVoluemOfDrankAlchogol);
        Console.WriteLine();
        student5.StudentInformation(summaryVoluemOfDrankAlchogol);
        Console.Write("\nВыполнение задачи завершено.\n");
    }
    public static void Main()
    {
        Console.WriteLine("Программа запущена успешно.");
        bool stopProgramm = false;
        while (!stopProgramm)
        {
            Console.WriteLine("\nВведите номер задачи (от 1 до 8), чтобы завершить просмотр задач введите 0\n");
            Console.Write("Номер задачи: ");
            try
            {
                int number_of_task = Convert.ToInt32(Console.ReadLine());
                switch (number_of_task)
                {
                    case 0:
                        stopProgramm = true;
                        continue;
                    case 1:
                        markup();
                        task1();
                        markup();
                        continue;
                    case 2:
                        markup();
                        task2();
                        markup();
                        continue;
                    case 3:
                        markup();
                        task3();
                        markup();
                        continue;
                    case 4:
                        markup();
                        task4();
                        markup();
                        continue;
                    case 5:
                        markup();
                        task5();
                        markup();
                        continue;
                    case 6:
                        markup();
                        task6();
                        markup();
                        continue;
                    case 7:
                        markup();
                        task7();
                        markup();
                        continue;
                    case 8:
                        markup();
                        task8();
                        markup();
                        continue;
                    default:
                        markup();
                        Console.WriteLine("\nОШИБКА: Введённые данные не принадлежат требуемому диапазону (от 0 до 9 включительно).\n");
                        markup();
                        continue;
                }
            }
            catch
            {
                markup();
                Console.Write("\nОШИБКА: Введённые данные не являются числом.\n");
                markup();
            }
        }
    }
}