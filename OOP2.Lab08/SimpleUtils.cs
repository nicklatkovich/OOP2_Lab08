using System;

namespace OOP2.Lab08 {
    public static class SimpleUtils {

        private static Random _rand = new Random( );

        public static int IRandom(int maxValue) {
            return _rand.Next(maxValue);
        }

    }
}
