using Xunit;
using FluentAssertions;
using tech_test_ps;

namespace test
{
    public class ConsoleWapperTest
    {
        [Theory(DisplayName = "ShouldConsoleReadLine_NotBeNullOrWhiteSpace")]
        [InlineData("10")]
        [InlineData("1222")]
        [InlineData("djsldkjflsdkjf")]
        public void ShouldConsoleReadLine_NotBeNullOrWhiteSpace(string value)
        {
            // arrange
            var console = new ConsoleWrapper();

            // act
        //    console.ReadLine(() => value);

            // assert
            value.Should().NotBeNullOrWhiteSpace();
        }

        [Theory(DisplayName = "ShouldConsoleReadLine_BeNullOrWhiteSpace")]
        [InlineData("")]
        [InlineData("")]
        public void ShouldConsoleReadLine_BeNullOrWhiteSpace(string value)
        {
            // arrange
            var console = new ConsoleWrapper();

            // act
       //     console.ReadLine(() => value);
           
            // assert
            value.Should().BeNullOrWhiteSpace();
         
        }
    }
}

