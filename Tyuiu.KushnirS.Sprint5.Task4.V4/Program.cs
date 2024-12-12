using Tyuiu.KushnirS.Sprint5.Task4.V4.Lib;
namespace Tyuiu.KushnirS.Sprint5.Task4.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "DataSprint5", "InPutDataFileTask4V4.txt");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}