using System;
using System.IO;
using System.Linq;
using System.Text;

namespace TDO.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"Payloads/1.txt");
            string base85 = Helper.ConvertLinesToSingleString(lines);

            byte[] payload = Helper.ConvertBase85ToBytes(base85);

            byte[] solvedPayload = Solutions.FirstChallenge.Apply(payload);

            string s = Helper.ConvertBytesToAscii(solvedPayload);
            Console.WriteLine(s);
            File.WriteAllText("ouput.log", s);
        }
    }
}
