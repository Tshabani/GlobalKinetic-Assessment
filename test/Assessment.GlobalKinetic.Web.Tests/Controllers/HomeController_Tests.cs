using System.Threading.Tasks;
using Assessment.GlobalKinetic.Models.TokenAuth;
using Assessment.GlobalKinetic.Web.Controllers;
using Shouldly;
using Xunit;

namespace Assessment.GlobalKinetic.Web.Tests.Controllers
{
    public class HomeController_Tests: GlobalKineticWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}