using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("1. Нахождение среднего значения четырех чисел");
                Console.WriteLine("2. Калькулятор");
                Console.WriteLine("3. Конвертация температуры");
                Console.WriteLine("4. Определение имени файла по пути");
                Console.WriteLine("5. Нахождение самого длинного слова в предложении");
                Console.WriteLine("6. Перемножение двух массивов");
                Console.WriteLine("7. Нахождение максимального и минимального числа");
                Console.WriteLine("8. Пирамидка из чисел");
                Console.WriteLine("9. Часть 2");
                Console.WriteLine("10. Вариант 27");
                Console.WriteLine("0. Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CalculateAverage();
                        break;
                    case "2":
                        Calculator();
                        break;
                    case "3":
                        ConvertTemperature();
                        break;
                    case "4":
                        GetFileNameFromPath();
                        break;
                    case "5":
                        FindLongestWord();
                        break;
                    case "6":
                        MultiplyArrays();
                        break;
                    case "7":
                        FindMaxMinNumbers();
                        break;
                    case "8":
                        PrintNumberPyramid();
                        break;
                    case "9":
                        Part2();
                        break;
                    case "10":
                        Var27();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
        // Задача 1: Среднее значение
        static void CalculateAverage()
        {
            Console.WriteLine("Enter the First number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Third number:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Fourth number:");
            double num4 = Convert.ToDouble(Console.ReadLine());

            double average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is: {average}");
        }
        // Задача 2: Калькулятор
        static void Calculator()
        {
            Console.WriteLine("Добро пожаловать в калькулятор!");

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Нахождение остатка (%)");
                Console.WriteLine("0. Назад");

                string choice = Console.ReadLine();

                if (choice == "0")
                    break;

                if (int.TryParse(choice, out int action) && action >= 1 && action <= 5)
                {
                    try
                    {
                        Console.Write("Введите первое число: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        double result = 0;

                        switch (action)
                        {
                            case 1:
                                result = num1 + num2;
                                Console.WriteLine($"Результат (Сложение): {result}");
                                break;
                            case 2:
                                result = num1 - num2;
                                Console.WriteLine($"Результат (Вычитание): {result}");
                                break;
                            case 3:
                                result = num1 * num2;
                                Console.WriteLine($"Результат (Умножение): {result}");
                                break;
                            case 4:
                                if (num2 != 0)
                                {
                                    result = num1 / num2;
                                    Console.WriteLine($"Результат (Деление): {result}");
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка: Деление на ноль!");
                                }
                                break;
                            case 5:
                                result = num1 % num2;
                                Console.WriteLine($"Результат (Нахождение остатка): {result}");
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: Пожалуйста, введите корректные числа.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: Неверный выбор. Пожалуйста, выберите действие от 1 до 5.");
                }
            }
        }

        // Задача 3: Конвертация температуры
        static void ConvertTemperature()
        {
            Console.WriteLine("Выберите шкалу вводимой температуры:");
            Console.WriteLine("1. Цельсий");
            Console.WriteLine("2. Кельвин");
            Console.WriteLine("3. Фаренгейт");

            int scaleChoice = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите показатель температуры (градусы):");
            double inputTemp = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите тип шкалы для конвертации:");
            Console.WriteLine("1. Цельсий");
            Console.WriteLine("2. Кельвин");
            Console.WriteLine("3. Фаренгейт");

            int convertChoice = int.Parse(Console.ReadLine());

            double resultTemp = 0;

            if (scaleChoice == 1) // Цельсий
            {
                if (convertChoice == 1) resultTemp = inputTemp;
                else if (convertChoice == 2) resultTemp = inputTemp + 273.15; // Цельсий в Кельвин
                else if (convertChoice == 3) resultTemp = inputTemp * 9 / 5 + 32; // Цельсий в Фаренгейт
            }
            else if (scaleChoice == 2) // Кельвин
            {
                if (convertChoice == 1) resultTemp = inputTemp - 273.15; // Кельвин в Цельсий
                else if (convertChoice == 2) resultTemp = inputTemp;
                else if (convertChoice == 3) resultTemp = (inputTemp - 273.15) * 9 / 5 + 32; // Кельвин в Фаренгейт
            }
            else if (scaleChoice == 3) // Фаренгейт
            {
                if (convertChoice == 1) resultTemp = (inputTemp - 32) * 5 / 9; // Фаренгейт в Цельсий
                else if (convertChoice == 2) resultTemp = (inputTemp - 32) * 5 / 9 + 273.15; // Фаренгейт в Кельвин
                else if (convertChoice == 3) resultTemp = inputTemp;
            }

            Console.WriteLine($"Результат конвертации: {resultTemp}");
        }

        // Задача 4: Определение имени файла по пути
        static void GetFileNameFromPath()
        {
            Console.WriteLine("Введите путь до файла:");
            string filePath = Console.ReadLine();
            string fileName = filePath.Split('/').Last();
            Console.WriteLine($"Имя файла: {fileName}");
        }

        // Задача 5: Нахождение самого длинного слова
        static void FindLongestWord()
        {
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            string longestWord = words.OrderByDescending(w => w.Length).First();
            Console.WriteLine($"Самое длинное слово: {longestWord}");
        }

        // Задача 6: Перемножение двух массивов
        static void MultiplyArrays()
        {
            Console.WriteLine("Введите значения для первого массива через пробел:");
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Введите значения для второго массива через пробел:");
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] resultArray = array1.Zip(array2, (a, b) => a * b).ToArray();

            Console.WriteLine($"Результат: {string.Join(" ", resultArray)}");
        }

        // Задача 7: Нахождение максимального и минимального числа
        static void FindMaxMinNumbers()
        {
            Console.WriteLine("Введите пять чисел:");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine($"Максимальное число: {numbers.Max()}");
            Console.WriteLine($"Минимальное число: {numbers.Min()}");
        }

        // Задача 8: Пирамидка из чисел
        static void PrintNumberPyramid()
        {
            Console.WriteLine("Введите количество ступеней:");
            int steps = int.Parse(Console.ReadLine());

            for (int i = 1; i <= steps; i++)
            {
                Console.WriteLine(string.Join("", Enumerable.Range(1, i)));
            }
        }
        static void Part2()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{i} х {j} = {i * j}\t");
                }
                Console.WriteLine();
            }
        }
        static void Var27()
        {
            Console.Write("Введите двузначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 10 || number > 99)
            {
                Console.WriteLine("Ошибка: Введите двузначное число.");
                return;
            }

            int firstDigit = number / 10;
            int secondDigit = number % 10;
            int sum = firstDigit + secondDigit;
            bool isSumDoubleDigit = sum >= 10 && sum < 100;

            Console.WriteLine($"Сумма цифр числа {number} " +
                              $"{(isSumDoubleDigit ? "является" : "не является")} двузначным числом (число {sum})");

            double power = Math.Pow(firstDigit, secondDigit);
            if (power > number)
            {
                Console.WriteLine($"Число {firstDigit} в степени {secondDigit} равно {power} и больше чем число {number}");
            }
            else
            {
                Console.WriteLine($"Число {firstDigit} в степени {secondDigit} равно {power} и не больше чем число {number}");
            }
            }
    }
}