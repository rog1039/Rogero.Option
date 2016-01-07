using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Rogero.Option.Tests
{
    public class ToOptionTests
    {
        [Fact()]
        [Trait("Category", "Instant")]
        public void NullToNone()
        {
            object o = null;
            var nullOption = o.ToOption();
            Assert.True(nullOption.HasValue == false);
            Assert.True(nullOption == o);
            Assert.True(o == nullOption);
        }

        [Fact()]
        [Trait("Category", "Instant")]
        public void NotNullToSome()
        {
            object o = new object();
            var notNullOption = o.ToOption();
            Assert.True(notNullOption.HasValue == true);
            Assert.True(notNullOption == o);
            Assert.True(o == notNullOption);
        }
    }

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
