// See https://aka.ms/new-console-template for more information

namespace Laba1
{
    class program_1
    {
        static void Main(){

            Console.WriteLine("Select task:");
            int project_number = Convert.ToInt32(Console.ReadLine()); 
            switch (project_number){
                case 1: 
                task_1();
                break;
                case 2:
                task_2();
                break;
                case 3:
                task_3();
                break;
            }
        }
        static void task_1()
        {
            Console.WriteLine("Enter variable");
            int a = Convert.ToInt32(Console.ReadLine()); 
            int perimetr = a*4;
            int square = a*a;

            Console.WriteLine("Perimetr = {0}", perimetr);
            Console.WriteLine("Square = {0}", square);

        }
        static void task_2()
        {   
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();
            Console.WriteLine("How old are you {0}?", name);
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age); // obvious lol
        }
        static void task_3()
        {   
            const double pi = Math.PI;
            Console.WriteLine("Enter radius:");
            double radius = Convert.ToInt32(Console.ReadLine());
            double circle_length = 2*pi*radius;
            double circle_square = pi*Math.Pow(radius, 2);
            double sphere_volume = 4/3*pi*Math.Pow(radius, 3);

            Console.WriteLine("Circle length is {0}", circle_length);
            Console.WriteLine("Circle square is {0}", circle_square);
            Console.WriteLine("Sphere volume is {0}", sphere_volume);

        }
    }
}