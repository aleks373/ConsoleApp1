using Microsoft.VisualBasic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Threading.Channels;
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

            //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            // var color = Console.ReadLine();

            //   if (color == "red")
            //   {
            //      Console.BackgroundColor = ConsoleColor.Red;
            //      Console.ForegroundColor = ConsoleColor.Black;
            //
            //     Console.WriteLine("Your color is red!");
            //  }

            //   else if (color == "green")
            //   {
            //       Console.BackgroundColor = ConsoleColor.Green;
            //      Console.ForegroundColor = ConsoleColor.Black;
            //
            //      Console.WriteLine("Your color is green!");
            //   }
            //   else
            //   {
            //       Console.ForegroundColor = ConsoleColor.Black;
            //
            //       Console.WriteLine("Your color is cyan!");
            //   }

            // Console.WriteLine("Цикл do");
            // int t = 0;

            // do
            // {
            //     Console.WriteLine(t);
            //     Console.WriteLine("Напишите свой любимый цыет на английском языке с маленькой буквы");
            //
            //     switch (Console.ReadLine())
            //     {

            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;
            //
            //           Console.WriteLine("Your color is red!");
            //         break;
            //
            //   case "green":
            //     Console.BackgroundColor = ConsoleColor.Green;
            //   Console.ForegroundColor = ConsoleColor.Black;
            //
            // Console.WriteLine("Your color is green!");
            //  break;
            // case "cyan":
            //   Console.BackgroundColor = ConsoleColor.Cyan;
            //  Console.ForegroundColor = ConsoleColor.Black;

            //  Console.WriteLine("Your color is cyan!");
            //  break;
            //default:
            //  Console.BackgroundColor = ConsoleColor.Yellow;
            // Console.ForegroundColor = ConsoleColor.Red;

            //Console.WriteLine("Your color is yellow!");
            //  break;
            // }
            //t++;
            // } while (t < 3);



            //  Console.WriteLine("Введите своё имя");

            //  var name = Console.ReadLine();

            //   Console.WriteLine("Ваше имя по буквам: ");

            // foreach (var ch in name)
            //{
            //  Console.Write(ch + " ");
            // }

            // Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length -2]);

            // Console.ReadKey();



            //nsole.WriteLine("Введите свое имя");
            //var name = Console.ReadLine();
            //for (int i = name.Length-1; i >= 0; i--)
            //{
            //     Console.WriteLine(name[i] + " ");
            // }
            // Console.ReadKey();


            //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            //Console.WriteLine(array.Length);


            /*
                        сvar num = 20 + 5;

                          Console.WriteLine("{0}", num);
                        */


            /*
            Console.WriteLine("Сколько вам лет?");
            var num1 = 23;
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько лет вашей маме?");
            var num2 = 55;
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вам :  " + num1 + ". Маме: " + num2 );
            Console.ReadKey();
            */




            /*
            Console.WriteLine("Введите площать круга");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area  = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Площадь круга c радиусом {0} равна : {1} ", radius , area);
            */


            /* Console.WriteLine("Вход с 18 лет. Введите свой возраст ");
             Console.ReadLine();
             int a = 18;

             if (a <= 18)
             {
                 Console.WriteLine("вам есть 18 проходите веселитесь");
             }

             else if (a <= 17 && a <= 16)
             {
                 Console.WriteLine("вам нет 18 валите");*/

            /*
                        var (name, age) = ("Евгения", 27);

                        Console.WriteLine("мое имя:  {0} ", name);
                        Console.WriteLine("мой возраст:  {0} ", age);

                        Console.Write("why is my name: ");
                        name = Console.ReadLine();
                        Console.Write("why is age: ");
                        age = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ваше имя : {0}",name);
                        Console.WriteLine("Ваш возраст : {0} ", age);
                        Console.ReadKey();
            */



            /* (string Name, string Type, double Age, int NameCount) Pet;

             Console.WriteLine("Введите имя питомца");
             Pet.Name = Console.ReadLine();
             Pet.NameCount = Pet.Name.Length;

             Console.WriteLine("Введите вид питомца: ");
             Pet.Type = Console.ReadLine();

             Console.WriteLine("Введите возраст питомца:");
             Pet.Age = double.Parse(Console.ReadLine());

             Console.WriteLine();*/



            //string str = "Слов";

            //if (str == "Слово")
            //{   Console.WriteLine("God");

            //}

            //else
            //{
            //    Console.WriteLine("no God");
            //}



            //int age = 18;
            //  Console.WriteLine(age == 10 ? "Yes" : "No");

            //string MyName = "Jane";
            //byte age = 30;
            //bool pets = true;
            //double size = 37.5;

            //Console.WriteLine("My name is {0}\n my age is {1}\n Do i have a pet {2}\n my shoe size is :{3} ", MyName , age, pets, size);




            //string Myname = "alex";
            //Console.WriteLine("привет мир!");
            //Console.WriteLine("");
            //Console.WriteLine($"Меня зовут {Myname}");


            //Console.Write("Enter your name:");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age:");
            //byte age = checked((byte)int.Parse(Console.ReadLine()));
            //int intage = age;
            //Console.WriteLine("your name is {0}\n your age is {1}",name,age);
            //Console.Write("What is your favorite day:");
            //DayOfWeek day= (DayOfWeek)int.Parse(Console.ReadLine());
            //Console.WriteLine(" your favorite day is {0}",day);



            //var a = 6;
            //var b = 7;

            //var c = a != b ? a + b : b;

            //Console.WriteLine(c);



            Console.WriteLine("напишите что то");
            var str = Console.ReadLine();
            Console.WriteLine("укажите угубину эха");
            var deep = int.Parse(Console.ReadLine());
            Echo(str, deep);
            Console.ReadKey();
        }
        static void Echo (string saidworld, int deep)
        {
            var modif = saidworld;
        
         if (modif.Length > 2) {
                modif = modif.Remove(0, 2);
                Console.WriteLine("..." + modif);
                if (deep>1 )
                {
                    Echo(modif, deep - 1);
                }
            }
          }
           }

        }
    


