using System;

namespace StandardLib
{
    public class TestClass
    {
        public static string Format(DateTime origial)
        {
            return origial.ToLongDateString();
        }
    }
}
