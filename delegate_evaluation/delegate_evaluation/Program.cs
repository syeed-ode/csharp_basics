using System;

namespace delegate_evaluation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // someMethod is a variable whose type is 'ConvertsIntToString'. 
            // It’s a lot like a reference variable, except instead of 
            // putting a label on an object on the heap you’re putting 
            // a label on a method.

            // You can set 'someMethod()' just like any other variable. 
            // When you call it like a method, it calls whatever method 
            // it happens to point to.

            // NOTE: The 'HiThere' method is an argument to the 
            // 'ConvertsIntToString' declaration. 
            ConvertsIntToString someMethod = new ConvertsIntToString(HiThere);


            // The 'someMethod' variable is pointing to the 'HiThere()' 
            // method.

            // When your program calls someMethod(5), it HiThere() and 
            // passes it the argument 5.
            string message = someMethod(5);

            // This causes it to return the string value “Hi there! 
            // #500” -— exactly as if it were called directly.
            Console.WriteLine(message);
            Console.ReadKey();
        }

        // This method’s signature matches 
        // ConvertsIntToString.
        private static string HiThere(int i)
        {
            return "Hi there! #" + (i * 100);
        }
    }
}
