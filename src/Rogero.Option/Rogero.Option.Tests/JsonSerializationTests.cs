using Newtonsoft.Json;
using Xunit;

namespace Rogero.Options.Tests
{
    public class JsonSerializationTests
    {
        [Fact()]
        [Trait("Category", "Instant")]
        public void RogeroOptionSerialization()
        {
            var option1 = Option<int>.Some(1);
            var optionNull = Option<int>.None;

            var option1Back = SerializeAndDeserialize(option1);
            var optionNullBack = SerializeAndDeserialize(optionNull);
        }

        private T SerializeAndDeserialize<T>(T obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var newObj = JsonConvert.DeserializeObject<T>(json);
            return newObj;
        }
    }
}