using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KushnirS.Sprint5.Task7.V2.Lib
{
    public class DataService : ISprint5Task7V2
    {
        public string LoadDataAndSave(string path)
        {
            string resPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V2.txt");

            FileInfo fileInfo = new FileInfo(resPath);
            bool fileExist = fileInfo.Exists;

            if (fileExist) { File.Delete(resPath); }

            string text = File.ReadAllText(path);

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    text = text.Replace(c, '#');
                }
            }

            File.AppendAllText(resPath, text);

            return resPath;

        }
    }
}