namespace AuthenticationAppTest.DAL
{
    using AuthenticationApplication.DAL;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using AuthenticationApplication.Entities;
    using AutoFixture;
    using AutoFixture.AutoMoq;

    [TestClass]
    public class UserServiceTest
    {
       // private Fixture fixture;
       //// private DbContextMock<DataContext> dataContext;
       // private Mock<IMapper> mapper;
       // private UserService instance;
       // private string userNme = "userName";
       // private string pwd = "password";
       // [TestInitialize]
       // public void Init()
       // {
       //     var dbContextMock = new DbContextMock<DataContext>("fake connectionstring");
       //     fixture = new Fixture();
       //     dataContext = new Mock<DataContext>();
       //     mapper = new Mock<IMapper>();
       //     instance = new UserService(dataContext.Object, mapper.Object);
       // }
       // [TestCleanup]
       // public void Cleanup()
       // {
       //     dataContext.VerifyAll();
       //     mapper.VerifyAll();
       // }
       // [TestMethod]
       // public void Login_Success_Case()
       // {
       //     var dbset = fixture.Customize(new AutoMoqCustomization()).Create<DbSet<User>>();
       //     dataContext.Setup(_ => _.Users).Returns(dbset);
       //     var result = instance.Login(userNme, pwd);
       //     Assert.IsNotNull(result);
       // }
    }
}
