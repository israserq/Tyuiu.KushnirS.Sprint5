using Tyuiu.KushnirS.Sprint5.Task6.V21.Lib;
namespace Tyuiu.KushnirS.Sprint5.Task6.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");


            string path = @"C:\Users\Sergey\source\repos\Tyuiu.KushnirS.Sprint5\DataSprint5\InPutDataFileTask6V21.txt";

            Console.WriteLine("Данные находяться в файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}