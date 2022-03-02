using CoffeeMaker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CoffeeMakerTest
{
    [TestClass]
    public class CoffeeTest
    {
        [TestMethod]
        public void OrderACoffee_Should_return_Received_Message()
        {
            StarbuckStore store = new(new Starbucks());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is received.", result);
        }

        [TestMethod]
        public void OrderACoffee_Should_Return_Received_MessageUsingStub()
        {
            StarbuckStore store = new(new StubStarbucks());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your order is received.", result);
        }

        //Moq MOCK

        [TestMethod]
        public void OrderACoffee_Should_Return_Received_MessageUsingMock()
        {
            var service = new Mock<StubStarbucks>();
            service.As<IMakeACoffee>().Setup(x => x.CheckIngredientAvailability()).Returns(true);
            service.As<IMakeACoffee>().Setup(x => x.CoffeeMaking(It.IsAny<int>(), It.IsAny<int>())).Returns("Your Order is received1.");
            //service.As<IMakeACoffee>().Setup(x => x.CheckIngredientAvailability()).Returns(false);

            StarbuckStore store = new(service.Object);
            var result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is received.", result);

        }
    }
}