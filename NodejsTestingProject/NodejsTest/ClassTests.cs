using NodejsTestingProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodejsTest
{
    public class ClassTests
    {
        [Fact]
        public void StandardTest()
        {
            Shirt shirt = new Shirt() { Color = "R", Size = 5};
            Assert.Equal("Red", shirt.Color);
            Assert.Equal(5, shirt.Size);
        } 
    }
}
