using PCPServerSDKDotNet;
using Xunit;

namespace PCPServerSDKDotNetTests
{
    public class Class1Tests
    {
        [Fact]
        public void GetsClassName()
        {
            // Arrange
            var class1 = new Class1();

            // Act
            string result = class1.GetClassName();

            // Assert
            Assert.Equal("Class1", result);
        }
    }
}
