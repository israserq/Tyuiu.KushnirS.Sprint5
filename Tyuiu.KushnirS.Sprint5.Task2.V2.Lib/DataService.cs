using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KushnirS.Sprint5.Task2.V2.Lib
{
    public class DataService : ISprint5Task2V2
    {
        public string SaveToFileTextData(int[,] M)
        {
            string Matrix = "";

    
            for (int I = 0; I < M.GetLength(0); I += 1)
            {
                for (int J = 0; J < M.GetLength(1); J += 1)
                {
                    if (J != M.GetLength(1) - 1)
                    {
                        if (M[I, J] < 0) { Matrix += "0;"; }
                        else if (M[I, J] >= 0) { Matrix += "1;"; }
                    }

                    else if (J == M.GetLength(1) - 1)
                    {
                        if (I != M.GetLength(0) - 1)
                        {
                            if (M[I, J] < 0) { Matrix += "0\n"; }
                            else if (M[I, J] >= 0) { Matrix += "1\n"; }
                        }
                        else if (I == M.GetLength(0) - 1)
                        {
                            if (M[I, J] < 0) { Matrix += "0"; }
                            else if (M[I, J] >= 0) { Matrix += "1"; }
                        }
                    }
                }
            }

            string T_Path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            File.WriteAllText(T_Path, Matrix);
            return Matrix;
        }
    }
}
