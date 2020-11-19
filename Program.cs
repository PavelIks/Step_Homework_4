using System;
using System.Text;

namespace Step_Homework_4
{
    class Program
    {
        /*Домашнее задание №5*/
        static void Main(string[] args)
        {
            /*Встреча №9*/
            /*Задание 1. Пользователь вводит с клавиатуры символ. Определить, какой это символ: Буква,
            цифра, знак препинания или другое.*/

            /*Console.Write("Введите символ: ");
            var X = Console.ReadLine();
            int result;
            bool isNum = int.TryParse(X, out result);
            if (isNum)
            {
                Console.WriteLine("Строка " + X + " - число!");
                Console.WriteLine(result);
            }
            else 
            {
                Console.WriteLine("Строка " + X + " - буква или другой символ...");
                Console.WriteLine(result);
            }*/

            string s;
            Console.Write("Enter string: ");
            s = Console.ReadLine();
            foreach (char c in s)
            {
                if (c >= 48 && c <= 57)
                {
                    Console.Write((int)c + " - ");
                    Console.WriteLine("это цифра! " + "(" + Convert.ToChar(c) + ")");
                }
                else if (c >= 65 && c <= 90)
                {
                    Console.Write((int)c + " - ");
                    Console.WriteLine("это большая англ. буква! " + "(" + Convert.ToChar(c) + ")");
                }
                else if (c >= 97 && c <= 122)
                {
                    Console.Write((int)c + " - ");
                    Console.WriteLine("это маленькая англ. буква! " + "(" + Convert.ToChar(c) + ")");
                }
                else if (c >= 1040 && c <= 1071)
                {
                    Console.Write((int)c + " - ");
                    Console.WriteLine("это большая русс. буква! " + "(" + Convert.ToChar(c) + ")");
                }
                else if (c >= 1072 && c <= 1103)
                {
                    Console.Write((int)c + " - ");
                    Console.WriteLine("это маленькая русс. буква! " + "(" + Convert.ToChar(c) + ")");
                }
                else if (c == 63 || c == 1111)
                {
                    Console.Write((int)c + " - ");
                    Console.WriteLine("это i либо ї... " + "(" + Convert.ToChar(c) + ")");
                }
                else
                {
                    Console.Write((int)c + " - ");
                    Console.WriteLine("это какой-то другой символ... " + "(" + Convert.ToChar(c) + ")");
                }
            }
            Console.ReadKey();
        }
    }
}