using AuthenticationApplication.Controllers;
using AuthenticationApplication.DAL;
using AuthenticationApplication.Models;
using AutoFixture;
using AutoFixture.AutoMoq;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AuthenticationAppTest
{
    [TestClass]
    public class UsersControllerTest
    {
        private Mock<IUserService> userService;
        private Mock<IMapper> mapper;
        private UsersController controller;
        private Fixture fixture;
        [TestInitialize]
        public void Init()
        {
            this.userService = new Mock<IUserService>();
            this.mapper = new Mock<IMapper>();
            fixture = new Fixture();
            controller = new UsersController(userService.Object, mapper.Object);
        }
        [TestCleanup]
        public void Cleanup()
        {
            this.userService.VerifyAll();
            this.mapper.VerifyAll();
        }

        [TestMethod]
        public void Register_PositiveCase_Test()
        {
            var data = fixture.Customize(new AutoMoqCustomization()).Create<User>();
            userService.Setup(_ => _.Register(It.IsAny<User>())).ReturnsAsync(true);
            var result = controller.Register(data);
            Assert.AreEqual(result.Result, true);
        }
    }
}
