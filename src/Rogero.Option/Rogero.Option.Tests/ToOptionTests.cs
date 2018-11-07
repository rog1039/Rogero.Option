using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Rogero.Options.Tests
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
}
