using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MinullinDF.Sprint6.Task1.V7.Lib
{
    public class DataService : ISprint6Task1V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] nums = new double[stopValue - startValue + 1];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                try {
                    y = Math.Round((2 * x - 3) / (Math.Cos(x) + x) + 5, 2);
                    nums[count] = y;
                } catch (DivideByZeroException) {
                    nums[count] = 0;
                }
                count++;
            }
            return nums;
        }
    }
}
