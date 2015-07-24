using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogero.Option
{
    public static class OptionExtensions
    {
        public static Option<T> DoIfValue<T>(this Option<T> source, Action<T> action)
        {
            if (source.HasValue)
            {
                action(source.Value);
            }
            return source;
        }

        public static TRes Match<T,TRes>(this Option<T> option, Func<T, TRes> some, Func<TRes> none)
        {
            if (option.HasValue)
                return some.Invoke(option.Value);
            else
                return none.Invoke();
        }

        public static void Match<T>(this Option<T> option, Action<T> some, Action none)
        {
            if (option.HasValue)
                some.Invoke(option.Value);
            else
                none.Invoke();
        }
    }
}
