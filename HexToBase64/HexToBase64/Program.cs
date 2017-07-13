using System;
using System.Text;

namespace HexToBase64
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexString;
            Console.WriteLine("Enter the hex string to be converted...");
            hexString = Console.ReadLine();
            Console.WriteLine(hexString);


            Console.WriteLine("This is the Hex string (encoded in UTF-16/Unicode in C#) converted to base64...");
            byte[] bytes = ConvertFromStringToHex(hexString);
            string base64 = Convert.ToBase64String(bytes);

            Console.WriteLine(base64);


            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }

        public static byte[] ConvertFromStringToHex(string inputHex)
        {
            inputHex = inputHex.Replace("-", "");

            byte[] resultantArray = new byte[inputHex.Length / 2];
            for (int i = 0; i < resultantArray.Length; i++)
            {
                resultantArray[i] = Convert.ToByte(inputHex.Substring(i * 2, 2), 16);
            }
            return resultantArray;
        }
    }
}