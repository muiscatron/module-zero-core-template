using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AbpCompanyName.AbpProjectName.foo;
using AbpCompanyName.AbpProjectName.Web.Controllers;
using Moq;
using Shouldly;
using Xunit;

namespace AbpCompanyName.AbpProjectName.Tests.foo
{
    public class FooControllerTests : AbpProjectNameTestBase
    {
        [Fact]
        public async Task GetFoos_Test()
        {
            var testFoos = new FooQueryResponse();
            testFoos.FooItems = new List<AbpProjectName.foo.Dto.FooItemDto> { new AbpProjectName.foo.Dto.FooItemDto {  Id = 1, FooName = "The Foo", FooDensity = 111, FooNickname = "MF"} };
            var mockFooService = new Mock<IFooAppService>();
            mockFooService.Setup(x => x.GetFoosAsync(It.IsAny<FooQueryRequest>())).ReturnsAsync(testFoos);

            var fooController = new FooController(mockFooService.Object);

            var result = await fooController.Index();

            result.ShouldNotBeNull();

            //TODO: more asserts

        }
    }
}
