using Shouldly;
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

            ifObject.ShouldNotBe(null);
            ifObject.Value.ShouldBe(integer);
            ifObject.ParamName.ShouldBeEmpty();
        }

        [Fact]
        public void If_CalledWitParamName_ReturnsValidIfObject()
        {
            var boolean = true;
            var paramName = "booleanParam";

            var ifObject = Check.If(boolean, paramName);

            ifObject.ShouldNotBe(null);
            ifObject.Value.ShouldBe(boolean);
            ifObject.ParamName.ShouldBe(paramName);
        }
    }
}
