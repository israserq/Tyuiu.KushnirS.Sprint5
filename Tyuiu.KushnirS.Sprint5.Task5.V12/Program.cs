using Tyuiu.KushnirS.Sprint5.Task5.V12.Lib;
namespace Tyuiu.KushnirS.Sprint5.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            string[] paths = { @"c:\DataSprint5", "InPutDataFileTask5V12.txt" };
            string fullPath = Path.Combine(paths);
            Console.WriteLine("Данные находятся в файле: " + fullPath);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");

            double res = ds.LoadFromDataFile(fullPath);
            Console.WriteLine("Разность элементов файла: " + res);

        }
    }
}
