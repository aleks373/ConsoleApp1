using System.ComponentModel;
using System.Diagnostics.Metrics;

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


            // string myName = "Jane";
            // int age = 27;
            //  string black = null;
            //  string favcolor = black;
            //  Console.WriteLine("Меня зовут {0}", myName);
            // Console.WriteLine("мой возраст {1}", age);
            //   Console.WriteLine("мой любимый цвет {3}", favcolor);
            //   Console.WriteLine("имя {0} \n мой возраст {1} \n мой любимый цвет{2}",name, age , favcolor);


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


            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1}", name,age);
            Console.Write("Enter your birthdate: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Your birthdate is {0}", birthdate);
            Console.ReadKey();


        }
    }
}