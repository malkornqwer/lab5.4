/*****************************
*   Лабораторная работа #5   *
*   Выполнил: Усиков С.А     *
*   Дата: 19.03.2023         *
******************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите директорию: "); string directory = Console.ReadLine();
        if (string.IsNullOrEmpty(directory))
        {
            directory = @"C:\Users\MaLkoRNqwer\source\repos";
        }

        var Dictionary = ErrorDictionary.GetDictionary();

        foreach (string File in Directory.GetFiles(directory))
        {
            using (StreamReader Reader = new StreamReader(File))
            {
                string txt = Reader.ReadToEnd();

                foreach (var Item in Dictionary)
                {
                    foreach (string IncorrectWord in Item.Value)
                    {
                        txt = txt.Replace(IncorrectWord, Item.Key);
                    }
                }

                txt = Regex.Replace(txt, @"\(0(\d{2})\)\s*(\d{3})-(\d{2})-(\d{2})", "+380 $1 $2 $3 $4");
                Reader.Close();
               
                using (StreamWriter Writer = new StreamWriter(File))
                {                   
                    Writer.Write(txt);
                    Writer.Close();
                }
            }
   
            Console.WriteLine($"Исправление в файле {File} завершено");
        }

        Console.WriteLine("Программа завершена.");
        Console.ReadLine();
    }
}