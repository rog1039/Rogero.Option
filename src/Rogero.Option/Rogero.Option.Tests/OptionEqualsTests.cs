using Xunit;

namespace Rogero.Options.Tests
{
    public class OptionEqualsTests
    {
        [Fact()]
        [Trait("Category", "Instant")]
        public void NonEqual()
        {
            object o1 = new object();
            object o2 = new object();
            Assert.False(o1 == o2);

            var option1 = o1.ToOption();
            var option2 = o2.ToOption();
            Assert.False(option1 == option2);
        }

        [Fact()]
        [Trait("Category", "Instant")]
        public void Equal()
        {
            object o1 = new object();
            Assert.True(o1 == o1);

            var option1 = o1.ToOption();
            var option2 = o1.ToOption();
            Assert.True(option1 == option2);
        }
    }
}