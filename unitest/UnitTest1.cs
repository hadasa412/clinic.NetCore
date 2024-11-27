
using Microsoft.AspNetCore.Mvc;
using netCore.Controllers;
using IDataContext;

namespace unitest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var id = 1;
            var test = new DoctorController();
            var result = test.Get(id);
            Assert.IsType<OkObjectResult>(result);
        }
    }
}