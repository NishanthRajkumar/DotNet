using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestApp;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        private Demo demo = new Demo();//1000
        //public UnitTest1()
        //{
        //    program =  new Program();//2000
        //}
        [TestMethod]
        public void TestMethod1()
        {
            //A-> Arrangement  A->Act  A->Assert
            //Arrangement
            demo = new Demo();
            //Act
            var result = demo.Add(5, 10);
            Assert.AreEqual(15, result);
        }
    }
}