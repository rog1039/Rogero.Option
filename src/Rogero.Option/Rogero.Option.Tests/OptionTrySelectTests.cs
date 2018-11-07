using System.Collections.Generic;
using System.Linq;
using Shouldly;
using Xunit;

namespace Rogero.Options.Tests
{
    public class OptionTrySelectTests
    {
        private class TestClass
        {
            public string Name { get; set; }
        }
        
        [Fact()]
        [Trait("Category", "Instant")]
        public void SimpleHasValue()
        {
            var sut = new TestClass() {Name = "John"};
            var result = sut.ToOption().TrySelect(z => z.Name);

            result.HasValue.ShouldBeTrue();
            result.Value.ShouldBe("John");
        }
        
        [Fact()]
        [Trait("Category", "Instant")]
        public void SimpleHasNoValue()
        {
            Option<TestClass> sut = Option<TestClass>.None;
            var result = sut.TrySelect(z => z.Name);

            result.HasValue.ShouldBeFalse();
            result.HasNoValue.ShouldBeTrue();
        }

        [Fact()]
        [Trait("Category", "Instant")]
        public void SimpleNonNullList()
        {
            var list = new List<string>() {"1", "2"};
            var optionList = list.ToOption();
            var intList = optionList.TrySelect(int.Parse);

            var total = intList.Value.Sum(z => z);
            Assert.True(total == 3);
        }

        [Fact()]
        [Trait("Category", "Instant")]
        public void SimpleNullList()
        {
            List<string> list = null;
            var optionList = list.ToOption();
            var intList = optionList.TrySelect(int.Parse);

            Assert.True(intList.HasNoValue);

            var set = new HashSet<int>();
        }
    }
}