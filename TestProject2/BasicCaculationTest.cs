using Practice1BasicCaculation;

namespace NunitTest
{
    public class BasicCaculationTest
    {

        [Test]
        public void Adding_Test()
        {
            //Arrange

            //Act
            int result = BasicCaculation.Caculation(1, 2, 1);
            //Asserting
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Option_Exception_Test()
        {
            //Arrange Act Asserting

                Assert.Throws<ArgumentOutOfRangeException>(()=>BasicCaculation.Caculation(1,2,0));
        }
    }
}