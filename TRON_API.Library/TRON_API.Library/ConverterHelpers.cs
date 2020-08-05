using System.Linq;
using TRON_API.Library.Helpers;

namespace TRON_API.Library
{
    public static class ConverterHelpers
    {
        public static decimal SunToTRX(long sunCoinsAmount) => sunCoinsAmount / 1_000_000; 
        
        public static string Base58ToHex(string base58String)
        {
            static string ByteToHexString(byte element)
            {
                const string hexByteMap = "0123456789ABCDEF";
                var firstIndex = element >> 4;
                var firstSymbol = hexByteMap[firstIndex];
                var secondIndex = element & 0x0f;
                var secondSymbol = hexByteMap[secondIndex];

                return new string(new[] {firstSymbol, secondSymbol});
            }
            
            var bytes = Base58Checker.Decode(base58String);
            var str = bytes.Aggregate(string.Empty, (current, byteItem) => current + ByteToHexString(byteItem));
            return str;
        }
    }
}