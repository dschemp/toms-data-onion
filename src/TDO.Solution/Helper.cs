using System;
using System.Text;

namespace TDO.Solution
{
    public static class Helper
    {
        public static string ConvertBase85ToAscii(string s)
        {
            Ascii85 ascii85 = new Ascii85();
            byte[] output = ascii85.Decode(s);

            return Encoding.ASCII.GetString(output);
        }

        public static string ConvertBytesToAscii(byte[] b)
        {
            return Encoding.ASCII.GetString(b);
        }

        public static byte[] ConvertBase85ToBytes(string s)
        {
            Ascii85 ascii85 = new Ascii85();
            return ascii85.Decode(s);
        }

        public static string ConvertLinesToSingleString(string[] lines)
        {
            return string.Join("", lines);
        }

        public static byte CircularRightBitShift(byte b, int n)
        {
            return (byte)((b >> n) | (b << (8 - n)));
        }
    }
}
