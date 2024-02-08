namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Notebook baseNotebook = new Notebook("Простой блокнот", 80);

            
            Console.WriteLine("информация о тетради:");
            baseNotebook.DisplayInformation();
            Console.WriteLine($"расходы: {baseNotebook.CalculateCost()} рублей.");

            

           
            CommonNotebook commonNotebook = new CommonNotebook("красная тетрадь", 100, "пластик");

            
            Console.WriteLine("Информация об общей тетради:");
            commonNotebook.DisplayInformationAboutChild();
            Console.WriteLine($"Расходы: {commonNotebook.CalculateCost()} рублей.");
            Console.ReadKey();
        }
    }
}
    
