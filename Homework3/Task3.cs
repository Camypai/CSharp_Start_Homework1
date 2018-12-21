using System;
using HomeworkLibrary;

namespace Homework3
{
    
    /// <summary>
    /// *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
    /// Предусмотреть методы сложения, вычитания, умножения и деления дробей.
    /// Написать программу, демонстрирующую все разработанные элементы класса.
    /// * Добавить свойства типа int для доступа к числителю и знаменателю;
    /// * Добавить проверку на ввод данных с помощью TryParse;
    /// * Добавить свойство типа double только на чтение, чтобы получить десятичную запись числа;
    /// ** Добавить проверку, чтобы знаменатель не равнялся 0.
    /// Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
    /// *** Добавить упрощение дробей.
    /// </summary>
    /// <author>
    /// Горшков Илья
    /// </author>
    public static class Task3
    {
        public static readonly Helpers.MenuItem MenuItem = new Helpers.MenuItem
        {
            Id = new[] {ConsoleKey.D3, ConsoleKey.NumPad3},
            Title = "Задание 3",
            Description =
                @"*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
Предусмотреть методы сложения, вычитания, умножения и деления дробей.
Написать программу, демонстрирующую все разработанные элементы класса.
* Добавить свойства типа int для доступа к числителю и знаменателю;
* Добавить проверку на ввод данных с помощью TryParse;
* Добавить свойство типа double только на чтение, чтобы получить десятичную запись числа;
** Добавить проверку, чтобы знаменатель не равнялся 0.
Выбрасывать исключение ArgumentException(""Знаменатель не может быть равен 0"");
*** Добавить упрощение дробей.",
            ItemMethod = Init
        };

        private static void Init()
        {
            try
            {
                Helpers.Print("Дроби вводить в виде \"1/2\"");
                var tryF1 = Fraction.TryParse(Helpers.Question("Введите первую дробь"), out var f1);
                var tryF2 = Fraction.TryParse(Helpers.Question("Введите вторую дробь"), out var f2);

                if (tryF1 && tryF2)
                    ShowOperationsWithFractions(f1, f2);
            }
            catch (ArgumentException ex)
            {
                Helpers.Print($"Произошла ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Helpers.Print($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                Helpers.Print();
                Helpers.Pause();
            }
        }

        private static void ShowOperationsWithFractions(Fraction f1, Fraction f2)
        {
            Helpers.Print($"{f1} + {f2} = {f1 + f2}");
            Helpers.Print($"{f1} - {f2} = {f1 - f2}");
            Helpers.Print($"{f1} * {f2} = {f1 * f2}");
            Helpers.Print($"{f1} / {f2} = {f1 / f2}");

            Helpers.Print($"Дробь {f1} как десятичная: {f1.Decimal}");
            Helpers.Print($"Числитель дроби {f1}: {f1.Numerator}");
            Helpers.Print($"Знаменатель дроби {f1}: {f1.Denominator}");
            Helpers.Print();
            
            Helpers.Print($"Дробь {f2} как десятичная: {f2.Decimal}");
            Helpers.Print($"Числитель дроби {f2}: {f2.Numerator}");
            Helpers.Print($"Знаменатель дроби {f2}: {f2.Denominator}");
            Helpers.Print();
            
            Helpers.Print($"Упрощённая дробь {f1}: {Fraction.Simple(f1)}");
            Helpers.Print($"Упрощённая дробь {f2}: {Fraction.Simple(f2)}");
        }
    }
}