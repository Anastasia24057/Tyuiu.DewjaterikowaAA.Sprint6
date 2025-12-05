using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DewjaterikowaAA.Sprint6.Task1.V10.Lib
{
    public class DataService : ISprint6Task1V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (3 * x + 0.5 == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    y = Math.Round(Math.Sin(x) + (2 / (3 * x + 0.5)) - 2 * Math.Cos(x) * 2 * x, 2);
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
        }
    }
}
