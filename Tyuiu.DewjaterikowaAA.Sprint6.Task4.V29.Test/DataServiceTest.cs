using Tyuiu.DewjaterikowaAA.Sprint6.Task4.V29.Lib;
namespace Tyuiu.DewjaterikowaAA.Sprint6.Task4.V29.Test
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

            valueMaitArray[0] = -32.26;
            valueMaitArray[1] = -27.50;
            valueMaitArray[2] = -22.80;
            valueMaitArray[3] = -17.95;
            valueMaitArray[4] = -12.97;
            valueMaitArray[5] = -9;
            valueMaitArray[6] = -0.31;
            valueMaitArray[7] = 3.77;
            valueMaitArray[8] = 8.57;
            valueMaitArray[9] = 13.42;
            valueMaitArray[10] = 18.28;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startvalue, stopvalue);
            CollectionAssert.AreEqual(valueMaitArray, res);
        }
    }
}
