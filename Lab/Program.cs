using System;

namespace Lab
{
    class Program
    {
        static void Task1() //Задание 1
        {
            Console.WriteLine("Class Human");
            Builder builder = new Builder("Max", "Buck", 27, "civil construction");
            Console.WriteLine(builder.ToString());
            Console.WriteLine("\n");
            Sailor sailor = new Sailor("Victor", "Jordan", 43, "commander");
            Console.WriteLine(sailor.ToString());
            Console.WriteLine("\n");
            Pilot pilot = new Pilot("Peter", "Wheeler", 32, "Boeing 737", "8417940");
            Console.WriteLine(pilot.ToString());
            Console.WriteLine("\n");
            Doctor doctor = new Doctor("Seth", "Daniels", 39, "physiotherapist", 6);
            Console.WriteLine(doctor.ToString());
        }
        static void Task2() //Задание 2
        {
            Console.WriteLine("Class Passport");
            ForeignPassport fpassport = new ForeignPassport("USA", "George", "Baker", 'M', "04.05.1974", "Chicago, USA", "16.06.2003", "16.06.2013", "hy356942");
            Console.WriteLine();
            Visa visa1 = new Visa("Switzerland", "S4828973", "32682871264826", "13.09.2005", "11.09.2015");
            Visa visa2 = new Visa("Myanmar", "R7326925", "16482826873876", "08.02.2009", "05.02.2019");
            fpassport.AddVisa(visa1);
            fpassport.AddVisa(visa2);
            fpassport.Print();
        }
        static void Task3() //Задание 3
        {
            Console.WriteLine("Class Animal");
            Tiger tiger = new Tiger("Rocky", "orange");
            tiger.Introduce();
            tiger.Walk();
            tiger.Hunt();
            Console.WriteLine("\n");
            Crocodile crocodile = new Crocodile("Dave", 73.4);
            crocodile.Introduce();
            crocodile.Swim();
            crocodile.Crawl();
            Console.WriteLine("\n");
            Kangaroo kangaroo = new Kangaroo("Skipper", 9.62);
            kangaroo.Introduce();
            kangaroo.Jump();
            Console.WriteLine();
        }
        static void Task4() //Задание 4
        {
            Console.WriteLine("Class Figure");
            Figure[] figures = new Figure[4];
            figures[0] = new Rectangle(14, 6);
            figures[1] = new Circle(17);
            figures[2] = new RightTriangle(12, 5);
            figures[3] = new Trapezoid(14, 20, 8);
            foreach(Figure figure in figures)
            {
                Console.WriteLine($"{figure}\nArea: {figure.CalculateArea()}\n");
            }
        }
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
    }
}