using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text2Hash
{
    class MD5
    {
    public static string GetMD5Hash(string text2)
        {
            byte[] message = Encoding.UTF8.GetBytes(text2);

            // Step 1: Padding
            int originalLength = message.Length;
            ulong bitLength = (ulong)originalLength * 8;

            int paddingLength = (56 - (originalLength + 1) % 64 + 64) % 64;
            byte[] paddedMessage = new byte[originalLength + 1 + paddingLength + 8];

            Array.Copy(message, paddedMessage, originalLength);
            paddedMessage[originalLength] = 0x80; // Append "1" bit

            byte[] lengthBytes = BitConverter.GetBytes(bitLength);
            Array.Copy(lengthBytes, 0, paddedMessage, paddedMessage.Length - 8, 8); // Append length in bits (little-endian)

            // Step 2: Initialize MD5 buffer
            uint A = 0x67452301;
            uint B = 0xefcdab89;
            uint C = 0x98badcfe;
            uint D = 0x10325476;

            // s specifies the per-round shift amounts
            int[] s = new int[]
            {
                7,12,17,22, 7,12,17,22, 7,12,17,22, 7,12,17,22,
                5,9,14,20, 5,9,14,20, 5,9,14,20, 5,9,14,20,
                4,11,16,23, 4,11,16,23, 4,11,16,23, 4,11,16,23,
                6,10,15,21, 6,10,15,21, 6,10,15,21, 6,10,15,21
            };

            uint[] K = new uint[64];
            for (int i = 0; i < 64; i++)
            {
                K[i] = (uint)(Math.Floor(Math.Abs(Math.Sin(i + 1)) * Math.Pow(2, 32)));
            }

            // Step 3: Process each 512-bit chunk
            for (int i = 0; i < paddedMessage.Length; i += 64)
            {
                uint[] M = new uint[16];
                for (int j = 0; j < 16; j++)
                {
                    M[j] = BitConverter.ToUInt32(paddedMessage, i + j * 4);
                }

                uint a = A;
                uint b = B;
                uint c = C;
                uint d = D;

                for (int k = 0; k < 64; k++)
                {
                    uint F, g;

                    if (k < 16)
                    {
                        F = (b & c) | (~b & d);
                        g = (uint)k;
                    }
                    else if (k < 32)
                    {
                        F = (d & b) | (~d & c);
                        g = (uint)((5 * k + 1) % 16);
                    }
                    else if (k < 48)
                    {
                        F = b ^ c ^ d;
                        g = (uint)((3 * k + 5) % 16);
                    }
                    else
                    {
                        F = c ^ (b | ~d);
                        g = (uint)((7 * k) % 16);
                    }

                    F = F + a + K[k] + M[g];
                    a = d;
                    d = c;
                    c = b;
                    b = b + LeftRotate(F, s[k]);
                }

                A += a;
                B += b;
                C += c;
                D += d;
            }

            // Step 4: Output
            byte[] result = new byte[16];
            Array.Copy(BitConverter.GetBytes(A), 0, result, 0, 4);
            Array.Copy(BitConverter.GetBytes(B), 0, result, 4, 4);
            Array.Copy(BitConverter.GetBytes(C), 0, result, 8, 4);
            Array.Copy(BitConverter.GetBytes(D), 0, result, 12, 4);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)   // foreach (byte b in result)
            {
                sb.Append(result[i].ToString("x2"));  //  sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }

        private static uint LeftRotate(uint x, int c)
        {
            return (x << c) | (x >> (32 - c));
        }
    }
}