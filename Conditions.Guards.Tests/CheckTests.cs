using Xunit;

namespace Conditions.Guards.Tests
{
    public class CheckTests
    {
        [Fact]
        public void If_CalledWithoutParamName_ReturnsValidIfObject()
        {
            var integer = 2;

            var ifObject = Check.If(integer);

            Assert.NotNull(ifObject);
            Assert.Equal(integer, ifObject.Value);
            Assert.Equal(string.Empty, ifObject.ParamName);
        }

        [Fact]
        public void If_CalledWitParamName_ReturnsValidIfObject()
        {
            var boolean = true;
            var paramName = "booleanParam";

            var ifObject = Check.If(boolean, paramName);

            Assert.NotNull(ifObject);
            Assert.Equal(boolean, ifObject.Value);
            Assert.Equal(paramName, ifObject.ParamName);
        }
    }
}
