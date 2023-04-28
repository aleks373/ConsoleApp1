using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string MyName = "Jane";
            // byte myAge = 30;
            // bool HaveIApets = true;
            //double sige = 37.5;

            // Console.WriteLine("Мое имя" + MyName);
            //Console.WriteLine("myAge" + myAge);
            //Console.WriteLine("Если ли у вас питомец?"+ HaveIApets);
            //Console.WriteLine("Какой у вас размер ноги?"+ sige);
            //Console.ReadKey();


            //Console.WriteLine("IntMin {0}",int.MinValue );
            //Console.WriteLine("intMax {0}",int.MaxValue );


            //const byte Monday = 1;
            //const byte Tuesday = 2;


            //enum Semaphore
            // {
            //     Red = 100,
            //     Yellow = 200,
            //     Green =300
            // }
            //Console.WriteLine("\t Привет,\n мир!");

            // string MyName = "Александр";
            // Console.WriteLine("Привет Мир");
            // Console.WriteLine();
            // Console.WriteLine("Меня зовут {0}", MyName) ;
            // Console.WriteLine("Меня зовут {0}", "Дима");

            // var age = 30;
            // var weight = 50;
            // Console.WriteLine("Мой Возраст {0} \n Мой Вес {1}", age ,weight);

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age: ");
            // var age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("your favorite color: ");
            //var favcolor = Console.ReadLine();
            //Console.WriteLine("{0} \n {1} \n {2}", name,age, favcolor);
            //var birthdate = Console.ReadLine();
            //Console.ReadKey();


            // Console.Write("Enter your age: ");
            // int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Your age is {0}", age );
            // Console.ReadKey();

            // Console.Write("Please your number: ");
            // int age = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Please Your favorite day is: ");
            // int day = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Your age is:  {0} \n favorite day is:  {1}", age , day);
            // Console.ReadKey();

            //Console.Write("давайте знакомится,назовите свое имя: ");
            //string name = Console.ReadLine();
            //Console.Write("Сколько вам лет?");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Здравствуйте:{0} \n  Мне сказали что вам: {1} лет " , name , age);
            //Console.ReadKey();


            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            // Console.Write("Enter your age: ");
            // var age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Your name is {0} and age is {1}", name,age);
            // Console.Write("Enter your birthdate: ");
            // var birthdate = Console.ReadLine();
            // Console.WriteLine("Your birthdate is {0}", birthdate);
            // Console.ReadKey();

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }
        }
    }
}