using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MinullinDF.Sprint6.Task6.V29.Lib
{
    public class DataService : ISprint6Task6V29
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (word.Contains("i"))
                        {
                            resStr = resStr + " " + word;
                        }
                    }

                }
            }
            return resStr.Trim();
        }
    }
}
