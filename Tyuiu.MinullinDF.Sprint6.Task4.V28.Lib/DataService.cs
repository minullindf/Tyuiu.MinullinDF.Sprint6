using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MinullinDF.Sprint6.Task4.V28.Lib
{
    public class DataService : ISprint6Task4V28
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
                    y = Math.Round(Math.Cos(2*x)+Math.Sin(x)/(x+2.5)+2*x, 2);
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
