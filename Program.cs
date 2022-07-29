using System;

namespace SecondSeminar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            // 456 -> 5
            // 782 -> 8
            // 918 -> 1
                /*
                Console.WriteLine("Программа выводит вторую цифру трехзначного цисла");
                Console.Write("Введи трёхзначное число ");

                int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
                string stringNumber = Convert.ToString(threeDigitNumber);
                Console.WriteLine("Вторая цифра этого числа: "+stringNumber[1]);
                */


            // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            // 645 -> 5
            // 78 -> третьей цифры нет
            // 32679 -> 6

                Console.WriteLine("Программа выводит третью цифру трехзначного цисла");
                Console.Write("Введи число ");

                int anyNumber = Convert.ToInt32(Console.ReadLine());
                string anyNumberText = Convert.ToString(anyNumber);

                if (anyNumberText.Length > 2){
                Console.WriteLine("Третья цифра: " + anyNumberText[2]);
                }
                else {
                Console.WriteLine("Это не трехзначное число");
                }


        }
    }
}
