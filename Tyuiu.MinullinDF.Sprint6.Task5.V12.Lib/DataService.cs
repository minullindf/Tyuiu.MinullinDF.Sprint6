using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MinullinDF.Sprint6.Task5.V12.Lib
{
    public class DataService : ISprint6Task5V12
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            using (StreamReader reader = new StreamReader(path))
            {
                string[] line = reader.ReadLine().Split(' ');
                for (int i = 0; i < line.Length; i++) 
                {
                    len++;
                }
            }
            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string[] nums;
                while ((line = reader.ReadLine()) != null)
                {
                    nums = line.Split(' ');
                    for (int i = 0; i < nums.Length; i++) 
                    {
                        numsArray[index] = Convert.ToDouble(nums[i]);
                        index++;
                    }
                }
            }
            numsArray = numsArray.Where(val => val < 0).ToArray();
            return numsArray;
        }
    }
}
