using AutoFixture;
using EnvelopeBudgeting.Api.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace EnvelopeBudgeting.UnitTests.IoC
{
    public class AppRouterTests
    {
        private readonly Fixture fixture;

        public AppRouterTests()
        {
            fixture = new Fixture();
        }

        [Fact]
        public void Test1()
        {
            var svcProvider = new Mock<IServiceProvider>();
            svcProvider.Setup(x => x.GetRequiredService<IUseCase<TestRequestResponseUseCase>>()).Returns(new ());
        }

        internal class TestRequest { }
        internal class TestRequestResponseUseCase { }
        internal class TestResponse { }
    }

    
}