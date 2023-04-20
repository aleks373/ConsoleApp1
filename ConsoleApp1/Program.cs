namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string MyName = "Jane";
            byte myAge = 30;
            bool HaveIApets = true;
            double sige = 37.5;
            
            Console.WriteLine("Мое имя" + MyName);
            Console.WriteLine("myAge" + myAge);
            Console.WriteLine("Если ли у вас питомец?"+ HaveIApets);
            Console.WriteLine("Какой у вас размер ноги?"+ sige);
            Console.ReadKey();         
        }
    }
}