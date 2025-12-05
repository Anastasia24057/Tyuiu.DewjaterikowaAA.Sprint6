using Tyuiu.DewjaterikowaAA.Sprint6.Task1.V10.Lib;
namespace Tyuiu.DewjaterikowaAA.Sprint6.Task1.V10.Test
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

            valueMaitArray[0] = 6.49;
            valueMaitArray[1] = -9.88;
            valueMaitArray[2] = -12.26;
            valueMaitArray[3] = -4.60;
            valueMaitArray[4] = 0.52;
            valueMaitArray[5] = 4;
            valueMaitArray[6] = -0.75;
            valueMaitArray[7] = 4.55;
            valueMaitArray[8] = 12.23;
            valueMaitArray[9] = 9.86;
            valueMaitArray[10] = -6.50;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startvalue, stopvalue);
            CollectionAssert.AreEqual(valueMaitArray, res);
        }
    }
}
