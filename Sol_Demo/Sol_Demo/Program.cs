#nullable enable
using System;

namespace Sol_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Warning: The nullable annotation is just for the compiler, at run time it can throw if the value is actually null.
            //Don't forget that some people may not use nullable context at the moment and won't get any warning. 
            //I think it is safer to add ArgumentNullException for public methods.

            // Basic Example

            // Non Nullable Type
            string value1 = null ;
            Value_NonNullable(value1); // Warning :  value may be null here.

            string value2 = "test";
            Value_NonNullable(value2);

            // Nullable type
            string? value3 = null;
            Value_Nullable(value3); // No Warning

            string? value4 = "test";
            Value_Nullable(value4);


            // null-forgiving operator
            string value5 = null; // Warning
            string value6 = null!; // No Warning : (we can use "!" to instruct the compiler "value" is not null here)

            var value = GetValue(true);
            Console.WriteLine(value.Length); // Warning

            // in this case we know that value is not null, so we can use "!" to instruct the compiler "value" is not null here
            Console.WriteLine(value!.Length); // No Warning by using null-forgiving operator

        }


        public static void Value_NonNullable(string value)
        {
            _ = value.Length; // ok 
        }

        public static void Value_Nullable(string? value)
        {
            _ = value?.Length; // ok 
        }

        public static string? GetValue(bool returnNotNullValue)
        {
            return returnNotNullValue ? "" : null;
        }

    }

    
}

