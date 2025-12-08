using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MinullinDF.Sprint6.Task2.V3.Lib
{
    public class DataService : ISprint6Task2V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] nums = new double[stopValue - startValue + 1];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                try
                {
                    y = Math.Round(Math.Sin(x)/(x+1.2)+Math.Cos(x) * 7 * x - 2, 2);
                    nums[count] = y;
                }
                catch (DivideByZeroException)
                {
                    nums[count] = 0;
                }
                count++;
            }
            return nums;
        }
    }
}
