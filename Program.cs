using System;

namespace csnotes{
    public static class Program {
        static void Main () {
            tester(1);
        }
        //tests

        public static void tester(int select){

            switch(select){
                case 1:
                    Console.WriteLine();
                    test1();
                    break;
                case 2:
                    test2();
                    break;
            }

        }

        public static void test1(){
            double[, ] d = new double[, ] { { 1, 2, 3, 4, 5 }, { 5, 4, 3, 2, 1 } };
            var slice = d.Slice (0);
            for (int i = 0; i < slice.Length; i++) {
                Console.WriteLine (slice[i]);
            }
        }
        public static void test2(){

        }
    }

}