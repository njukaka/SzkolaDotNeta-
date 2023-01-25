using System;
using System.Collections.Generic;

namespace _2._8.PetleZad
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.

            //A)

            //int globalCounter = 0;
            //for (int a = 1; a <= 100; a++)
            //{
            //    int counter = 0;
            //    for (int b = 1; b <= 100; b++)
            //    {
            //        if (a % b == 0)
            //        {
            //            counter++;
            //        }
            //    }
            //    if (counter == 2)
            //    {
            //        globalCounter++;
            //    }
            //}

            //Console.WriteLine($"W zakresie 0-100 jest {globalCounter} liczb pierwszych");

            //________________________________

            //B)

            //int globalCounter = 0;
            //for (int a = 2; a <= 100; a++)
            //{
            //    int counter = 0;
            //    for (int b = 1; b <= Math.Sqrt(a); b++)
            //    {

            //        if (a % b == 0)
            //        {
            //            counter++;

            //        }
            //    }
            //    if (counter == 1)
            //    {
            //        globalCounter++;
            //        Console.WriteLine(a);
            //    }
            //}
            //Console.WriteLine($"W zakresie 0-100 jest {globalCounter} liczb pierwszych");
            //______________________________________________________________________________________________

            //2. Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.

            //int a = 0;
            //int b = 2;
            //Console.WriteLine("Wszystkie liczby parzyste w przedziale 0-1000");
            //do
            //{
            //    if (a % b == 0)
            //    {
            //        Console.WriteLine($"{a}");
            //    }
            //    a++;
            //}
            //while (a<=1000);
            //______________________________________________________________________________________________

            //3. Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.

            //Console.WriteLine("Podaj górną granicę: ");
            //int end = Int32.Parse(Console.ReadLine());
            //int a = 0, b = 1, c = 1;
            //string result = "";
            //do
            //{
            //    result += a + " ";
            //    b = c;
            //    c = a;
            //    a = b + c;
            //}
            //while (a <= end);
            //Console.WriteLine($"{result}");
            //______________________________________________________________________________________________________

            //4. Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:

            //Console.WriteLine("Podaj górną granicę: ");
            //int end = Int32.Parse(Console.ReadLine());
            //int count = 1;
            //for (int a = 1; count <= end; a++)
            //{
            //    for (int b = 1; b <= a; b++)
            //    {
            //        Console.Write($"{count} ");
            //        count++;
            //    }
            //    Console.WriteLine("");
            //}
            //______________________________________________________________________________________________________

            //5. Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.

            //for (int a = 1; a <= 20; a++)
            //{
            //    int result = a * a * a;
            //    Console.WriteLine(result);
            //}
            //______________________________________________________________________________________________________

            //6. Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru: 1+ ½ + 1/3 + ¼ itd.

            //for (int a = 0; a<=20; a++)
            //{
            //    double sum = 0;
            //    for (int b=1; b<=a; b++)
            //    {
            //        sum += 1F / b;
            //    }
            //    if (a == 20)
            //    {
            //        Console.WriteLine("According to the formula when values go as follows: 1 + 1/2 + 1/3 + 1/4... ");
            //        Console.WriteLine("For scope 0-20 the sum will be: {0}", sum);
            //    }
            //}
            //______________________________________________________________________________________________________

            //7. Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:...

            //Console.WriteLine("Type in a number for diamond's shorter diagonal: ");
            //int input = Int32.Parse(Console.ReadLine());
            //int diag = input + 1;
            //for (int a = 1; a <= diag; a++)
            //{
            //    for (int b = 1; b <= diag - a; b++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int b = 1; b <= a - 1; b++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.Write("\n");
            //}
            //for (int a = diag - 1; a >= 1; a--)
            //{
            //    for (int b = 1; b <= diag - a; b++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int b = 1; b <= a - 1; b++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.Write("\n");
            //}
            //______________________________________________________________________________________________________

            //8. Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków.

            //Console.WriteLine("Type in a string for reversal: ");
            //string input = Console.ReadLine();
            //input = input.ToLower();
            //int lenght = input.Length;
            //char [] chars = input.ToCharArray();
            //int a=1;
            //for (a = lenght - 1; a >= 0; a--)
            //{
            //    if (a == lenght-1)
            //    {
            //        Console.Write(char.ToUpper(chars[a]));
            //    }
            //    else
            //    Console.Write(chars[a]);
            //}
            //______________________________________________________________________________________________________

            //9. Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.

            //Console.WriteLine("Type in a decimal number for converting it to binary: ");
            //string result = "";
            //List<char> resultList = new List<char>();
            //int input = int.Parse(Console.ReadLine());
            //int division = 0;
            //for (int a = 1; input >= 1; a++)
            //{
            //    char b;
            //    if (input % 2 == 0)
            //    {
            //        b = '0';
            //    }
            //    else
            //        b = '1';
            //    result += b;
            //    resultList.Add(b);
            //    division = input / 2;
            //    input = division;
            //}
            //int lenght = result.Length;
            //for (int c=lenght-1; c>=0; c--)
            //{
            //    Console.Write(result[c]);
            //}
            //______________________________________________________________________________________________________

            //10. Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
            
            //Console.WriteLine("Type in numbers for finding least common multiple.");
            //Console.WriteLine("Type in first number: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Type in second number: ");
            //int b = int.Parse(Console.ReadLine());
            //for (int c =1; c<=(a*b); c++)
            //{
            //    if ((c % a == 0) && (c % b == 0))
            //    {
            //        Console.WriteLine(c);
            //        break;
            //    }
            //}

        }
    }
}


        
    

