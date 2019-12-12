using AutoFixture.Xunit2;
using AutoFIxture.Examples;
using Moq;
using System.Linq;
using System.Reflection;
using Xunit;

namespace AutoFixture.Examples.Tests
{
    public class CreateCustomerTests
    {
        [Theory, AutoMoqData]
        public void ValidCustomerIsSaved(
            CustomerDto dto,
            [Frozen]Mock<ICustomerRepository> mockRepo,
            CustomerController sut)
        {
            sut.CreateCustomer(dto);

            mockRepo.Verify(
                a => a.Create(It.IsAny<Customer>()),
                Times.Once);
        }


    }
}
