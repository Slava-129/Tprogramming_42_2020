using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double a, double b, double x)
        {
            var numerator = 1 + Math.Pow(Math.Log(x / a), 2);
            var denominator = b - Math.Exp(x / a);
            var y = numerator / denominator;
            return y;
        }

        public static (double x, double y)[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            var res = new(double, double)[(int)Math.Ceiling((xk - xn) / dx) + 1];
            int i = 0;
            for (var x = xn; x <= xk; x += dx)
            {
                var y = Calc(a, b, x);
                res[i] = (x, y);
                i++;
            }

            return res;
        }

        public static (double x, double y)[] TaskB(double a, double b, double[] xItems)
        {
            var res = new(double, double)[xItems.Length];
            int i = 0;
            foreach (var x in xItems)
            {
                var y = Calc(a, b, x);
                res[i] = (x, y);
                i++;
            }

            return res;
        }

        public static void Main(string[] args)
        {
            const double a = 2.0;
            const double b = 0.95;
            Console.WriteLine($"--------- TASK A --------------");
            var taskA = TaskA(a, b, 1.25, 2.75, 0.3);
            foreach (var item in taskA)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"--------- TASK B --------------");
            double[] xItems = { 2.2, 3.78, 4.51, 6.58, 1.2 };
            var taskB = TaskB(a, b, xItems);
            foreach (var item in taskB)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"-------------------------------");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Vjacheslav Gvozdev");
            Console.WriteLine($"--------- Class ---------------\n");
            Dog dog_1 = new Dog();
            Dog dog_2 = new Dog("dog_2");
            Cat cat_1 = new Cat("Cat_1", " ");
            Cat cat_2 = new Cat("cat_2", "abyssinian", 2);
            Animal[] animals = new Animal[] { dog_1, dog_2, cat_1, cat_2 };
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.DisplayInf());
            }

            Console.WriteLine();
            dog_1.EditInf("dog_1", " ", 0);
            dog_2.Breed = "d";
            dog_2.EditAge(3);
            Console.WriteLine(dog_2.GetAge());
            cat_1.EditInf("Cat-1", "a", 1);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.DisplayInf());
                Console.WriteLine(animal.Vois());
            }

            Console.ReadLine();
        }
    }
}
