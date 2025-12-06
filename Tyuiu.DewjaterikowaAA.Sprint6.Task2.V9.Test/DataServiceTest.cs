using Tyuiu.DewjaterikowaAA.Sprint6.Task2.V9.Lib;
namespace Tyuiu.DewjaterikowaAA.Sprint6.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();
            int startvalue = -5;
            int stopvalue = 5;

            int len = stopvalue - startvalue + 1;

            double[] valueMaitArray;
            valueMaitArray = new double[len];

            valueMaitArray[0] = 4.34;
            valueMaitArray[1] = 4.16;
            valueMaitArray[2] = 3.71;
            valueMaitArray[3] = 3.27;
            valueMaitArray[4] = 2.93;
            valueMaitArray[5] = 2.5;
            valueMaitArray[6] = 0.71;
            valueMaitArray[7] = -47.61;
            valueMaitArray[8] = 55.15;
            valueMaitArray[9] = 45.17;
            valueMaitArray[10] = 14.97;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startvalue, stopvalue);
            CollectionAssert.AreEqual(valueMaitArray, res);
        }
    }
}
