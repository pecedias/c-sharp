using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2 {
    class Calculator {

        public static void Triple(ref int x) {
            x = x * 3;
        }

        public static void TripleOut(int origin, out int result) {
            result = origin * 3;
        }

    }
}
