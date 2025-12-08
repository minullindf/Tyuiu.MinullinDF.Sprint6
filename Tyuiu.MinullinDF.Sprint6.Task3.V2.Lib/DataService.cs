using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MinullinDF.Sprint6.Task3.V2.Lib
{
    public class DataService : ISprint6Task3V2
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;


            int[] list = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                if (matrix[0, i] % 2 == 0)
                {
                    list[i] = 0;
                }
                else 
                {
                    list[i] = matrix[0, i];
                }
            }
            for (int i = 0; i < rows; i++)
            {
                matrix[0, i] = list[i];
            }
            return matrix;
        }
    }
}
