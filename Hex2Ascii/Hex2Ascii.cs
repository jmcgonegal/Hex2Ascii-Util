using System;
using System.Text;

namespace Hex2Ascii
{
    class Hex2Ascii
    {
        static string Converter(string val)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < val.Length; i+=2)
            {
                string chunk = val.Substring(i, 2);

                output.Append(Convert.ToString(Convert.ToChar(Int32.Parse(chunk, System.Globalization.NumberStyles.HexNumber))));
            }

            return output.ToString();
        }
        static void Main(string[] args)
        {
            string val = "61727420686973746f7274792070617274203120756e6974203320526576696577";
            Console.WriteLine(val);
            Console.WriteLine(Converter(val));
            Console.ReadKey();
        }
    }
}
