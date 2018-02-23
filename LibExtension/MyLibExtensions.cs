using System.Collections;

namespace LibExtension
{
    public static class MyLibExtensions
    {
        public static bool In<T>(this T o, IEnumerable c)
        {
            foreach (T i in c)
            {
                if (i.Equals(o))
                    return true;
            }
            return false;
        }
    }
}