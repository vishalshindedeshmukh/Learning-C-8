﻿using System;

namespace chapter_03
{
   class Program
   {
      static void if_demo()
      {
         Console.WriteLine("Enter a positive integer");
         var line = Console.ReadLine();
         int.TryParse(line, out int number);

         if (number % 2 == 0)
         {
            Console.WriteLine("Even number");
         }
         else
         {
            Console.WriteLine("Odd number");
         }
      }

      static void switch_demo()
      {
         Console.WriteLine("Enter number (1-10)");
         var line = Console.ReadLine();
         int.TryParse(line, out int number);
         switch (number)
         {
            case 1:
               Console.WriteLine("Smallest number");
               break;
            case 2:
            case 3:
            case 5:
            case 7:
               Console.WriteLine("Prime number");
               break;
            case 4:
            case 6:
            case 8:
               Console.WriteLine("Even number");
               break;
            case 9:
               Console.WriteLine("Odd number");
               break;
            default:
               Console.WriteLine("Not in the range");
               break;
         }
      }

      static void for_demo()
      {
         for (int i = 0; i <= 10; i++)
         {
            if (i % 2 == 0)
            {
               Console.WriteLine($"{i} is an even number");
            }
            else
            {
               Console.WriteLine($"{i} is an odd number");
            }
         }

         for (int i = 1; i < 5; i++)
         {
            for (int j = 1; j < 3; j++)
            {
               Console.WriteLine($"i = {i},j = {j}");
            }
         }

         for (; ; )
         {
            break;
         }
      }

      static void while_demo()
      {
         int i = 0;
         while (i <= 10)
         {
            if (i % 2 == 0)
            {
               Console.WriteLine($"{i} is an even number");
            }
            else
            {
               Console.WriteLine($"{i} is an odd number");
            }
            i++;
         }
      }

      static void do_while_demo()
      {
         int i = 0;
         do
         {
            if (i % 2 == 0)
            {
               Console.WriteLine($"{i} is an even number");
            }
            else
            {
               Console.WriteLine($"{i} is an odd number");
            }
            i++;
         }
         while (i <= 10);
      }

      static void foreach_demo()
      {
         string[] languages = { "Java", "C#", "Python", "C++", "JavaScript" };

         foreach (string lang in languages)
         {
            Console.WriteLine(lang);
         }

         var enumerator = languages.GetEnumerator();
         while (enumerator.MoveNext())
         {
            Console.WriteLine(enumerator.Current);
         }
      }

      static void ref_foreach_demo()
      {
         Span<int> arr = stackalloc int[]{ 1, 1, 2, 3, 5, 8 };
         foreach(ref int n in arr)
         {
            n *= 2;
         }

         foreach(ref readonly var n in arr)
         {
            Console.WriteLine(n);
         }
      }

      static void Main(string[] args)
      {
         if_demo();
         switch_demo();
         for_demo();
         while_demo();
         do_while_demo();
         foreach_demo();
         ref_foreach_demo();
      }
   }
}