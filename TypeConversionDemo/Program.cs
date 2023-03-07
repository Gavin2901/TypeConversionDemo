using System;

namespace TypeConversion
{ 
    class Program
    {
        static void Main(string[] args)
        { 
            int i = 1;
            byte b1 = (byte) i; //  <= cast
            Console.WriteLine(b1);
            //C# knows there will be a chance data loss so it asks for a cast

            var number = "1234"; //we want to convert this string to an int
            int k = Convert.ToInt32(number); 
            Console.WriteLine(k);


            // to convert string to byte (it wont work as 1234 is too large)

            try
            {
                var bNumber = "1234";
                byte b2 = Convert.ToByte(bNumber);
                Console.WriteLine(b2); //if we tried this normally we would get an error as value is too large for a byte
            }
            catch (Exception ) 
            {
                Console.WriteLine("The number could not be converted to a byte");
                // we use this try and catch with an exception to avoid the error crashing and instead pushes our own message
                //if you tried to run this without the try and catch, you would experience an error and/or crash
            
            }   


            try
            {
                string str = "true";
                bool b3 = Convert.ToBoolean(str);
                Console.WriteLine(b3);
                // this shows how you would convert a string to a boolean 
            }
            catch (Exception )
            {
                Console.WriteLine("dont worky lol");
            }
        }
    }
}
