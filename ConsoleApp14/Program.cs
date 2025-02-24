﻿using System;

class Program
{
    static void Main()
    {

        string input = "29535123p48723487597645723645";
        Console.ForegroundColor = ConsoleColor.DarkCyan;


        long sum = 0;


        for (int i = 0; i < input.Length; i++)
        {

            for (int a = i + 1; a < input.Length; a++)
            {

                string substring = input.Substring(i, a - i + 1);


                if (IsValidNumber(substring))
                {

                    PrintWithHighlight(input, i, a);


                    sum += long.Parse(substring);

                }
            }
        }


        Console.WriteLine();
        Console.WriteLine($"Summa = {sum}");
    }


    static bool IsValidNumber(string s)
    {

        if (!long.TryParse(s, out _))
            return false;


        if (s[0] != s[s.Length - 1])
            return false;


        char firstChar = s[0];
        for (int i = 1; i < s.Length - 1; i++)
        {
            if (s[i] == firstChar)
                return false;
        }

        return true;
    }


    static void PrintWithHighlight(string text, int start, int end)
    {

        ConsoleColor originalColor = Console.ForegroundColor;


        Console.Write(text.Substring(0, start));


        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write(text.Substring(start, end - start + 1));


        Console.ForegroundColor = originalColor;
        Console.WriteLine(text.Substring(end + 1));

    }
}