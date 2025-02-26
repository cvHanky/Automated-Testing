namespace NodejsTest
{
    public class NoClassTests
    {
        [Fact]
        public void StandardTest()
        {
            int result = 5 + 7;
            Assert.Equal(12, result);
        }
    }
}