using System.Linq;

namespace TDO.Solution.Solutions
{
    public static class FirstChallenge
    {
        public static byte[] Apply(byte[] bytes)
        {
            byte[] firstStep = bytes.Select(b => (byte)(b ^ 0b01010101)).ToArray();
            byte[] secondStep = firstStep.Select(b => Helper.CircularRightBitShift(b, 1)).ToArray();
            return secondStep;
        }
    }
}
