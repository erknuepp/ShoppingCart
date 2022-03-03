namespace UnitTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using ShoppingCart;

    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void Item_ToString_Test()
        {
            const string expectedResult = "test $1.23 999\n";

            //arrange
            var item = new Item("test", 1.23m, 999);

            //act
            var actualResult = item.ToString();

            //assert
            Assert.AreEqual(expectedResult, actualResult, "we expect the result to be formatted correctly.");
        }  
    }
}