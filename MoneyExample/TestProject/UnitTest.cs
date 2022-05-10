using Xunit;

namespace TestProject
{
    public class UnitTest
    {
        [Fact]
        public void TestMultiplication()
        {
            Dollar five = Dollar.Give(5);

            Dollar ten = five.Times(2);

            Assert.Equal(10, ten.Amount);
        }
    }
}