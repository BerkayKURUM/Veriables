namespace Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data types in c programming languages

            #region Short, Integer, Long, Byte, SByte, UShort, UInt, ULong

            //Byte-8 Bit
            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Min. Value:\t {Byte.MinValue}");         //The minimum value a byte can take
            Console.WriteLine($"Max. Value:\t {Byte.MaxValue}");         //The maximum value a byte can take
            Console.WriteLine($"Size:\t {sizeof(Byte)}");              // The values that a byte can take

            Console.WriteLine(new string('*', 40));                     //Star Line

            //SByte-8 bit
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Min. Value:\t {SByte.MinValue}");        // The minimum value a signed byte can take
            Console.WriteLine($"Max . Value:\t {SByte.MaxValue}");        // The maximum value a signed byte can take
            Console.WriteLine($"Size:\t {sizeof(SByte)}");             // The values that a signed byte can take

            Console.WriteLine(new string('*', 40));                    

            //Short-16 bit
            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Min. Value:\t {Int16.MinValue}");        // The minimum value a (Int 16)short can take
            Console.WriteLine($"Max. Value:\t {Int16.MaxValue}");        // The maximum value a (Int 16)short can take
            Console.WriteLine($"Size:\t {sizeof(Int16)}");             // The values that a (Int 16)short can take

            Console.WriteLine(new string('*', 40));                    

            //UShort-16 bit
            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Min. Value:\t {UInt16.MinValue}");       // The minimum value an unsigned short can take
            Console.WriteLine($"Max. Value:\t {UInt16.MaxValue}");       // The maximum value an unsigned short can take
            Console.WriteLine($"Size:\t {sizeof(UInt16)}");            // The values that an unsigned short can take

            Console.WriteLine(new string('*', 40));

            //Int-32 bit
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Min. Value:\t {Int32.MinValue}");        //  The minimum value an (Int 32)int can take
            Console.WriteLine($"Max. Valuet:\t {Int32.MaxValue}");        //  The maximum value an (Int 32)int can take
            Console.WriteLine($"Size:\t {sizeof(Int32)}");             //  The values that an (Int 32)int can take

            Console.WriteLine(new string('*', 40));

            //UInt-32 bit
            Console.WriteLine(nameof(UInt32));
            Console.WriteLine($"Min. Value:\t {UInt32.MinValue}");       // The minimum value an unsigned int can take
            Console.WriteLine($"Max. Value:\t {UInt32.MaxValue}");       // The maximum value an unsigned int can take
            Console.WriteLine($"Size:\t {sizeof(UInt32)}");            // The values that an unsigned int can take

            Console.WriteLine(new string('*', 40));

            //long-64 bit
            Console.WriteLine(nameof(Int64));
            Console.WriteLine($"Min. Value:\t {Int64.MinValue}");        // The minimum value a (Int 64)long can take
            Console.WriteLine($"Max. Value:\t {Int64.MaxValue}");        // The maximum value a (Int 64)long can take
            Console.WriteLine($"Size:\t {sizeof(Int64)}");             // The values that a (Int 64)long can take

            Console.WriteLine(new string('*', 40));

            //ulong-64 bit
            Console.WriteLine(nameof(UInt64));
            Console.WriteLine($"Min. Value:\t {UInt64.MinValue}");       // The minimum value an unsigned long can take
            Console.WriteLine($"Max. Value:\t {UInt64.MaxValue}");       // The maximum value an unsigned long can take
            Console.WriteLine($"Size:\t {sizeof(UInt64)}");            // The values that an unsigned long can take

            Console.WriteLine(new string('*', 40));
            #endregion

            #region Double , Float, Decimal

            float ondalikSayi1 = 12.5f;
            double ondalikSayi2 = 12.5D;
            decimal ondalikSayi3 = 12.5m;

            //Float 9 digit support after "."
            Console.WriteLine(nameof(Single));
            Console.WriteLine($"Min. Value:\t {float.MinValue}");        // The minimum value a float can take
            Console.WriteLine($"Max. Value:\t {float.MaxValue}");        // The maximum value a float can take
            Console.WriteLine($"Size:\t {sizeof(float)}");             // The values that a float can take

            Console.WriteLine(new string('*', 40));                     // Star Line

            //Double 17 digit support after "."
            Console.WriteLine(nameof(Double));
            Console.WriteLine($"Min. Value:\t {double.MinValue}");       // The minimum value a double can take  
            Console.WriteLine($"Max. Value:\t {double.MaxValue}");       // The maximum value a double can take  
            Console.WriteLine($"Size:\t {sizeof(double)}");            // The values that a double can take

            Console.WriteLine(new string('*', 40));

            //Decimal 29 digit support after "."
            Console.WriteLine(nameof(Decimal));
            Console.WriteLine($"Min. Value:\t {decimal.MinValue}");      // The minimum value a decimal can take 
            Console.WriteLine($"Max. Value:\t {decimal.MaxValue}");      // The maximum value a decimal can take
            Console.WriteLine($"Size:\t {sizeof(decimal)}");           // The values that a decimal can take

            Console.WriteLine(new string('*', 40));
            #endregion

            #region String, Char
            //Char
            Console.WriteLine(nameof(Char));                // Char is a single character data type (Char Size is 2 byte)
            Console.WriteLine($"Size:\t {sizeof(char)}");

            Console.WriteLine(new string('*', 40));        // Star Line

            //String
            Console.WriteLine(nameof(String));             // String is infinite character data type
            //Console.WriteLine($"Boyut:\t {sizeof(String)}");

            Console.WriteLine(new string('*', 40));
            #endregion

            #region Boolean
            Console.WriteLine(nameof(Boolean));                 // Boolean is a data type that can take true or false values (1 Bite)
            Console.WriteLine($"Size:\t {sizeof(Boolean)}");
            #endregion

            #region Question
            int a = 5;
            int b = a;
            b = b * 2;
            Console.WriteLine($"A: {a} B: {b}");    //What happenes to the ouput?

            string s = "Hello";
            string x = s;
            x = x + "World";
            Console.WriteLine($"S: {s} B: {x}");    //What happenes to the ouput?

            string str1 = "Hello";
            string str2 = str1;
            str1 = "World";
            Console.WriteLine(str2);                //What happenes to the ouput?

            #endregion

            #region Object

            //Object is the ancestor of everyrhing in C#.

            object obj1 = 42;           // Can contain all data types
            object obj2 = 45.4;         // Then it can convert into what is desired
            object obj3 = "Hello";      //object = Convert.ToString(obj2); // Object to String conversion
            object obj4 = true;

            #endregion

            #region Var

            //1-Compiel Time 2-Run Time
            // Takes on the type to which it is assigned at compile time
            var var1 = 10;              
            var var2 = 22.4;
            var var3 = "Merhaba";
            var var4 = false;

            Console.WriteLine(var1 * 2);


            #endregion

            #region Dynamic
            //Takes on the type to which it is assigned at run time.
            dynamic degisken1 = 10;
            dynamic degisken2 = "Metin";
            dynamic degisken3 = true;

            #endregion

        }
    }
}
