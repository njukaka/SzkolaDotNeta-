using System;

namespace _2._7.WarunkiZad
{
    class Program
    {
        //2.7.1
        //Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie. 
        //Dane testowe: a : 5 b : 5 Rezultat w terminalu : 5 i 5 są równe
        //
        //static void Main(string[] args)
        //{
        //    int a, b;
        //    Console.WriteLine("Podaj pierwszą liczbę: ");
        //    a = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Podaj drugą liczbę: ");
        //    b = int.Parse(Console.ReadLine());
        //    if (a == b)
        //    {
        //        Console.WriteLine("Liczby są równe!");
        //    }
        //    else
        //        Console.WriteLine("Liczby nie są równe");
        //}

        //2.7.2
        //Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta. 
        //Dane testowe : 15 Rezultat w terminalu : 15 jest liczbą nieparzystą
        //
        //static void Main(string[] args)
        //{
        //    int a;
        //    Console.WriteLine("Podaj liczbę: ");
        //    a = int.Parse(Console.ReadLine());
        //    if (a % 2 == 0)
        //    {
        //        Console.WriteLine("{0} to liczba parzysta", a);
        //    }
        //    else
        //        Console.WriteLine("{0} nie jest liczbą parzystą", a);
        //}

        //2.7.3
        //Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna. 
        //Dane testowe : 14 Rezultat w terminalu : 14 jest liczbą dodatnią
        //
        //static void Main(string[] args)
        //{
        //    int a;
        //    Console.WriteLine("Podaj liczbę: ");
        //    a = int.Parse(Console.ReadLine());
        //    if (a > 0)
        //    {
        //        Console.WriteLine("{0} to liczba dodatnia", a);
        //    }
        //    if (a < 0)
        //    {
        //        Console.WriteLine("{0} to liczba ujemna", a);
        //    }
        //    if (a == 0)
        //    {
        //        Console.WriteLine("{0} jest zerem", a);
        //    }
        //}

        //2.7.4
        //Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym. 
        //Dane testowe : 2016 Rezultat w terminalu : 2016 jest rokiem przestępnym
        //
        //static void Main(string[] args)
        //{
        //    int a;
        //    Console.WriteLine("Podaj rok: ");
        //    a = int.Parse(Console.ReadLine());
        //    if (a % 4 == 0)
        //    {
        //        if (a % 100 == 0)
        //        {
        //            if (a % 400 == 0)
        //                Console.WriteLine("{0} jest rokiem przestępnym", a);
        //            else
        //                Console.WriteLine("{0} nie jest rokiem przestępnym", a);
        //        }
        //        else
        //            Console.WriteLine("{0} jest rokiem przestępnym", a);
        //    }
        //    else
        //        Console.WriteLine("{0} nie jest rokiem przestępnym", a);
        //}

        //2.7.5
        //Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, prezydenta. 
        //Dane testowe : 21 Rezultat w terminalu : Możesz zostać posłem
        //
        //static void Main(string[] args)
        //{
        //    int a;
        //    Console.WriteLine("Podaj wiek: ");
        //    a = int.Parse(Console.ReadLine());
        //    if (a >= 35)
        //    {
        //        Console.WriteLine("Możesz zostać prezydentem");
        //    }
        //    if (a >= 30)
        //    {
        //        Console.WriteLine("Możesz zostać senatorem");
        //    }
        //    if (a >= 21)
        //    {
        //        Console.WriteLine("Możesz zostać posłem");
        //        Console.WriteLine("Możesz zostać premierem");
        //    }
        //}

        //2.7.6
        //Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu. 
        //Dane testowe : 140 Rezultat w terminalu : Jesteś krasnoludem
        //
        //static void Main(string[] args)
        //{
        //    int a;
        //    Console.WriteLine("Podaj wzrost: ");
        //    a = int.Parse(Console.ReadLine());
        //    if (a <= 100)
        //    {
        //        Console.WriteLine("Frodo się o Ciebie pytał");
        //    }
        //    if ((a <= 140) & (a >100))
        //    {
        //        Console.WriteLine("Gimli patrzy Ci w oczy stojąc");
        //    }
        //    if ((a <= 180) & (a > 140))
        //    {
        //        Console.WriteLine("Ramię w ramię w Aragornem");
        //    if ((a <= 200) & (a > 180))
        //    {
        //        Console.WriteLine("Między Gandalfem a Sarumanem");
        //    }
        //    if ((a <= 240) & (a > 200))
        //    {
        //        Console.WriteLine("Sauron B4L");
        //    }
        //    if (a > 240)
        //    {
        //        Console.WriteLine("Zbijasz pionę z entami");
        //    }
        //    }
        //}

        //2.7.7
        //Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa 
        //Dane testowe: 25 63 79 Rezultat w terminalu : 79 jest największa z podanych
        //
        //    static void Main(string[] args)
        //{
        //    int a, b, c;
        //    Console.WriteLine("Podaj liczbę: ");
        //    a = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Podaj liczbę: ");
        //    b = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Podaj liczbę: ");
        //    c = int.Parse(Console.ReadLine());
        //    if ((a > b) && (a > c))
        //        Console.WriteLine("{0} jest największa", a);
        //    if ((a > b) && (a < c))
        //        Console.WriteLine("{0} jest największa", c);
        //    if ((b > a) && (b > c))
        //        Console.WriteLine("{0} jest największa", b);
        //    if ((b > a) && (b < c))
        //        Console.WriteLine("{0} jest największa", c);
        //    if ((a == b) && (a > c))
        //        Console.WriteLine("{0} jest największa", a);
        //    if ((a == b) && (a < c))
        //        Console.WriteLine("{0} jest największa", c);
        //    if ((a == c) && (a > b))
        //        Console.WriteLine("{0} jest największa", a);
        //    if ((b == c) && (b > a))
        //        Console.WriteLine("{0} jest największa", b);
        //    if ((a == b) && (a == c))
        //        Console.WriteLine("{0} jest największa", a);
        //}

        //2.7.8
        //Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów: Wynik z Matury z matematyki powyżej 70 Wynik z fizyki powyżej 55 Wynik z chemii powyżej 45 Łączny wynik z 3 przedmiotów powyżej 180 Albo Wynik z matematyki i jednego przedmiotu powyżej 150 
        //Dane testowe: Matematyka 80 Fizyka 71 Chemia 0 Rezultat w terminalu : Kandydat dopuszczony do rekrutacji
        //
        //static void Main(string[] args)
        //{
        //    int a, b, c;
        //    Console.WriteLine("Podaj wynik z matematyki: ");
        //    a = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Podaj wynik z fizyki: ");
        //    b = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Podaj wynik z chemii: ");
        //    c = int.Parse(Console.ReadLine());
        //    if (((a > 70) && (b > 55) && (c > 45)) || (a + b + c > 180) || ((a + b > 150) || (a + c > 150)))
        //    {
        //        Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
        //    }
        //    else
        //        Console.WriteLine("Kandydat NIE dopuszczony do rekrutacji.");
        //}

        //2.7.9
        //Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach Temp < 0 – cholernie piździ Temp 0 – 10 – zimno Temp 10 – 20 – chłodno Temp 20 – 30 – w sam raz Temp 30 – 40 – zaczyna być słabo, bo gorąco Temp >= 40 – a weź wyprowadzam się na Alaskę. 
        //Dane testowe : 41 Rezultat w terminalu : a weź wyprowadzam się na Alaskę.
        //
        //static void Main(string[] args)
        //{
        //    int a;
        //    Console.WriteLine("Wprowadź temperaturę: ");
        //    a = int.Parse(Console.ReadLine());
        //    if (a < 0)
        //        Console.WriteLine("Cholernie piździ");
        //    if ((a >= 0) && (a < 10))
        //        Console.WriteLine("Zimno");
        //    if ((a >= 10) && (a < 20))
        //        Console.WriteLine("Chłodno");
        //    if ((a >= 20) && (a < 30))
        //        Console.WriteLine("W sam raz");
        //    if ((a >= 30) && (a < 40))
        //        Console.WriteLine("słabo bo gorąco");
        //    if (a >= 40)
        //        Console.WriteLine("Skwar");
        //}

        //2.7.10
        //Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt 
        //Dane testowe : 40 55 65 Rezultat w terminalu : Można zbudować trójkąt
        //
        //static void Main(string[] args)
        //{
        //    int a, b, c, ab, ac, bc;
        //    Console.WriteLine("Podaj długość pierwszego boku: ");
        //    a = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Podaj długość drugiego boku: ");
        //    b = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Podaj długość trzeciego boku: ");
        //    c = int.Parse(Console.ReadLine());
        //    ab = a + b;
        //    ac = a + c;
        //    bc = b + c;
        //    if ((ab > c) && (ac > b) && (bc > a))
        //        Console.WriteLine("Można zbudować trójkąt");
        //    else
        //        Console.WriteLine("Nie można zbudować trójkąta");
        //}

        //2.7.11
        //Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
        //Dane testowe : 3 Rezultat w terminalu : Dostateczny
        //
        //static void Main(string[] args)
        //{
        //    int a;
        //    Console.WriteLine("Podaj ocenę: ");
        //    a = int.Parse(Console.ReadLine());
        //    if (a == 1)
        //        Console.WriteLine("Niedostateczny");
        //    if (a == 2)
        //        Console.WriteLine("Dopuszczający");
        //    if (a == 3)
        //        Console.WriteLine("Dostateczny");
        //    if (a == 4)
        //        Console.WriteLine("Dobry");
        //    if (a == 5)
        //        Console.WriteLine("Bardzo dobry");
        //    if (a == 6)
        //        Console.WriteLine("Celujący");
        //}

        //2.7.12
        //Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę 
        //Dane testowe : 4 Rezultat w terminalu : Czwartek
        //
        //static void Main(string[] args)
        //{
        //    int a;
        //    Console.WriteLine("Wpisz numer dnia tygodnia: ");
        //    a = int.Parse(Console.ReadLine());
        //    if (a == 1)
        //        Console.WriteLine("Poniedziałek");
        //    if (a == 2)
        //        Console.WriteLine("Wtorek");
        //    if (a == 3)
        //        Console.WriteLine("Środa");
        //    if (a == 4)
        //        Console.WriteLine("Czwartek");
        //    if (a == 5)
        //        Console.WriteLine("Piątek");
        //    if (a == 6)
        //        Console.WriteLine("Sobota");
        //    if (a == 7)
        //        Console.WriteLine("Niedziela");
        //}

        //2.7.13
        //Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem Podaj pierwszą liczbę: … Podaj drugą liczbę: … Podaj numer operacji do wykonania:
        //
        //    static void Main(string[] args)
        //{
        //    int a, b, result = 0;
        //    string c;
        //    Console.WriteLine("Podaj pierwszą liczbę: ");
        //    a = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Podaj drugą liczbę: ");
        //    b = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Jakie działanie chcesz wykonać?");
        //    Console.WriteLine("Wprowadź '+' dla dodawania, '-' dla odejmowania, '*' dla mnożenia, '/' dla dzielenia");
        //    c = (Console.ReadLine());
        //    if (c == "+")
        //    {
        //        result = a + b;
        //        Console.WriteLine("Twój wynik to {0}", result);
        //    }
        //    if (c == "-")
        //    {
        //        result = a - b;
        //        Console.WriteLine("Twój wynik to {0}", result);
        //    }
        //    if (c == "*")
        //    {
        //        result = a * b;
        //        Console.WriteLine("Twój wynik to {0}", result);
        //    }
        //    if (c == "/")
        //    {
        //        result = a / b;
        //        Console.WriteLine("Twój wynik to {0}", result);
        //    }

    }

} 
    
    

    
    
    
    
