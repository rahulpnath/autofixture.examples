using AutoFIxture.Examples;
using Xunit;

namespace AutoFixture.Examples.Tests
{
    public class CustomerDtoTests
    {
        [Theory, AutoMoqData]
        public void Test(CustomerDto sut)
        {
            Assert.NotNull(sut);
        }
    }
}
