using System;
using System.Text;

namespace MicroMsg.sdk.utils
{
    internal static class Md5Util
    {
        

        private static uint[] Converter(byte[] input, int ibStart)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Unable convert null array to array of uInts");
            }
            uint[] numArray = new uint[0x10];
            for (int i = 0; i < 0x10; i++)
            {
                numArray[i] = input[ibStart + (i * 4)];
                numArray[i] += (uint)(input[(ibStart + (i * 4)) + 1] << 8);
                numArray[i] += (uint)(input[(ibStart + (i * 4)) + 2] << 0x10);
                numArray[i] += (uint)(input[(ibStart + (i * 4)) + 3] << 0x18);
            }
            return numArray;
        }

        private static byte[] GetHash(string input)
        {
            return GetHash(input, new UTF8Encoding());
        }

        private static byte[] GetHash(byte[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Unable to calculate hash over null input data");
            }
            AbcdStruct abcdValue = new AbcdStruct
            {
                A = 0x67452301,
                B = 0xefcdab89,
                C = 0x98badcfe,
                D = 0x10325476
            };
            int ibStart = 0;
            while (ibStart <= (input.Length - 0x40))
            {
                GetHashBlock(input, ref abcdValue, ibStart);
                ibStart += 0x40;
            }
            return GetHashFinalBlock(input, ibStart, input.Length - ibStart, abcdValue, input.Length * 8L);
        }

        private static byte[] GetHash(string input, Encoding encoding)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Unable to calculate hash over null input data");
            }
            if (encoding == null)
            {
                throw new ArgumentNullException(nameof(encoding), "Unable to calculate hash over a string without a default encoding. Consider using the GetHash(string) overload to use UTF8 Encoding");
            }
            return GetHash(encoding.GetBytes(input));
        }

        internal static void GetHashBlock(byte[] input, ref AbcdStruct abcdValue, int ibStart)
        {
            uint[] numArray = Converter(input, ibStart);
            uint a = abcdValue.A;
            uint b = abcdValue.B;
            uint c = abcdValue.C;
            uint d = abcdValue.D;
            a = R1(a, b, c, d, numArray[0], 7, 0xd76aa478);
            d = R1(d, a, b, c, numArray[1], 12, 0xe8c7b756);
            c = R1(c, d, a, b, numArray[2], 0x11, 0x242070db);
            b = R1(b, c, d, a, numArray[3], 0x16, 0xc1bdceee);
            a = R1(a, b, c, d, numArray[4], 7, 0xf57c0faf);
            d = R1(d, a, b, c, numArray[5], 12, 0x4787c62a);
            c = R1(c, d, a, b, numArray[6], 0x11, 0xa8304613);
            b = R1(b, c, d, a, numArray[7], 0x16, 0xfd469501);
            a = R1(a, b, c, d, numArray[8], 7, 0x698098d8);
            d = R1(d, a, b, c, numArray[9], 12, 0x8b44f7af);
            c = R1(c, d, a, b, numArray[10], 0x11, 0xffff5bb1);
            b = R1(b, c, d, a, numArray[11], 0x16, 0x895cd7be);
            a = R1(a, b, c, d, numArray[12], 7, 0x6b901122);
            d = R1(d, a, b, c, numArray[13], 12, 0xfd987193);
            c = R1(c, d, a, b, numArray[14], 0x11, 0xa679438e);
            b = R1(b, c, d, a, numArray[15], 0x16, 0x49b40821);
            a = R2(a, b, c, d, numArray[1], 5, 0xf61e2562);
            d = R2(d, a, b, c, numArray[6], 9, 0xc040b340);
            c = R2(c, d, a, b, numArray[11], 14, 0x265e5a51);
            b = R2(b, c, d, a, numArray[0], 20, 0xe9b6c7aa);
            a = R2(a, b, c, d, numArray[5], 5, 0xd62f105d);
            d = R2(d, a, b, c, numArray[10], 9, 0x2441453);
            c = R2(c, d, a, b, numArray[15], 14, 0xd8a1e681);
            b = R2(b, c, d, a, numArray[4], 20, 0xe7d3fbc8);
            a = R2(a, b, c, d, numArray[9], 5, 0x21e1cde6);
            d = R2(d, a, b, c, numArray[14], 9, 0xc33707d6);
            c = R2(c, d, a, b, numArray[3], 14, 0xf4d50d87);
            b = R2(b, c, d, a, numArray[8], 20, 0x455a14ed);
            a = R2(a, b, c, d, numArray[13], 5, 0xa9e3e905);
            d = R2(d, a, b, c, numArray[2], 9, 0xfcefa3f8);
            c = R2(c, d, a, b, numArray[7], 14, 0x676f02d9);
            b = R2(b, c, d, a, numArray[12], 20, 0x8d2a4c8a);
            a = R3(a, b, c, d, numArray[5], 4, 0xfffa3942);
            d = R3(d, a, b, c, numArray[8], 11, 0x8771f681);
            c = R3(c, d, a, b, numArray[11], 0x10, 0x6d9d6122);
            b = R3(b, c, d, a, numArray[14], 0x17, 0xfde5380c);
            a = R3(a, b, c, d, numArray[1], 4, 0xa4beea44);
            d = R3(d, a, b, c, numArray[4], 11, 0x4bdecfa9);
            c = R3(c, d, a, b, numArray[7], 0x10, 0xf6bb4b60);
            b = R3(b, c, d, a, numArray[10], 0x17, 0xbebfbc70);
            a = R3(a, b, c, d, numArray[13], 4, 0x289b7ec6);
            d = R3(d, a, b, c, numArray[0], 11, 0xeaa127fa);
            c = R3(c, d, a, b, numArray[3], 0x10, 0xd4ef3085);
            b = R3(b, c, d, a, numArray[6], 0x17, 0x4881d05);
            a = R3(a, b, c, d, numArray[9], 4, 0xd9d4d039);
            d = R3(d, a, b, c, numArray[12], 11, 0xe6db99e5);
            c = R3(c, d, a, b, numArray[15], 0x10, 0x1fa27cf8);
            b = R3(b, c, d, a, numArray[2], 0x17, 0xc4ac5665);
            a = R4(a, b, c, d, numArray[0], 6, 0xf4292244);
            d = R4(d, a, b, c, numArray[7], 10, 0x432aff97);
            c = R4(c, d, a, b, numArray[14], 15, 0xab9423a7);
            b = R4(b, c, d, a, numArray[5], 0x15, 0xfc93a039);
            a = R4(a, b, c, d, numArray[12], 6, 0x655b59c3);
            d = R4(d, a, b, c, numArray[3], 10, 0x8f0ccc92);
            c = R4(c, d, a, b, numArray[10], 15, 0xffeff47d);
            b = R4(b, c, d, a, numArray[1], 0x15, 0x85845dd1);
            a = R4(a, b, c, d, numArray[8], 6, 0x6fa87e4f);
            d = R4(d, a, b, c, numArray[15], 10, 0xfe2ce6e0);
            c = R4(c, d, a, b, numArray[6], 15, 0xa3014314);
            b = R4(b, c, d, a, numArray[13], 0x15, 0x4e0811a1);
            a = R4(a, b, c, d, numArray[4], 6, 0xf7537e82);
            d = R4(d, a, b, c, numArray[11], 10, 0xbd3af235);
            c = R4(c, d, a, b, numArray[2], 15, 0x2ad7d2bb);
            b = R4(b, c, d, a, numArray[9], 0x15, 0xeb86d391);
            abcdValue.A = a + abcdValue.A;
            abcdValue.B = b + abcdValue.B;
            abcdValue.C = c + abcdValue.C;
            abcdValue.D = d + abcdValue.D;
        }

        internal static byte[] GetHashFinalBlock(byte[] input, int ibStart, int cbSize, AbcdStruct abcd, long len)
        {
            byte[] destinationArray = new byte[0x40];
            byte[] bytes = BitConverter.GetBytes(len);
            Array.Copy(input, ibStart, destinationArray, 0, cbSize);
            destinationArray[cbSize] = 0x80;
            if (cbSize <= 0x38)
            {
                Array.Copy(bytes, 0, destinationArray, 0x38, 8);
                GetHashBlock(destinationArray, ref abcd, 0);
            }
            else
            {
                GetHashBlock(destinationArray, ref abcd, 0);
                destinationArray = new byte[0x40];
                Array.Copy(bytes, 0, destinationArray, 0x38, 8);
                GetHashBlock(destinationArray, ref abcd, 0);
            }
            byte[] buffer3 = new byte[0x10];
            Array.Copy(BitConverter.GetBytes(abcd.A), 0, buffer3, 0, 4);
            Array.Copy(BitConverter.GetBytes(abcd.B), 0, buffer3, 4, 4);
            Array.Copy(BitConverter.GetBytes(abcd.C), 0, buffer3, 8, 4);
            Array.Copy(BitConverter.GetBytes(abcd.D), 0, buffer3, 12, 4);
            return buffer3;
        }

        private static string GetHashString(byte[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Unable to calculate hash over null input data");
            }
            return BitConverter.ToString(GetHash(input)).Replace("-", "");
        }

        internal static string GetHashString(string input)
        {
            return GetHashString(input, new UTF8Encoding());
        }

        private static string GetHashString(string input, Encoding encoding)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Unable to calculate hash over null input data");
            }
            if (encoding == null)
            {
                throw new ArgumentNullException(nameof(encoding), "Unable to calculate hash over a string without a default encoding. Consider using the GetHashString(string) overload to use UTF8 Encoding");
            }
            return GetHashString(encoding.GetBytes(input));
        }

        private static uint Lsr(uint i, int s)
        {
            return ((i << s) | (i >> (0x20 - s)));
        }

        private static uint R1(uint a, uint b, uint c, uint d, uint x, int s, uint t)
        {
            return (b + Lsr(((a + ((b & c) | ((b ^ uint.MaxValue) & d))) + x) + t, s));
        }

        private static uint R2(uint a, uint b, uint c, uint d, uint x, int s, uint t)
        {
            return (b + Lsr(((a + ((b & d) | (c & (d ^ uint.MaxValue)))) + x) + t, s));
        }

        private static uint R3(uint a, uint b, uint c, uint d, uint x, int s, uint t)
        {
            return (b + Lsr(((a + ((b ^ c) ^ d)) + x) + t, s));
        }

        private static uint R4(uint a, uint b, uint c, uint d, uint x, int s, uint t)
        {
            return (b + Lsr(((a + (c ^ (b | (d ^ uint.MaxValue)))) + x) + t, s));
        }
    }
}

