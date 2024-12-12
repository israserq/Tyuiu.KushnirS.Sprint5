using Tyuiu.KushnirS.Sprint5.Task2.V2.Lib;
namespace Tyuiu.KushnirS.Sprint5.Task2.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         


            DataService DS = new DataService();
            var T = DS.SaveToFileTextData(new int[3, 3] { { -7, 7, 5 }, { 4, 2, -7 }, { 2, 6, -4 } });
            Console.WriteLine("РЕЗУЛЬТАТ: ");
            Console.WriteLine(T);
        }
    }
}
