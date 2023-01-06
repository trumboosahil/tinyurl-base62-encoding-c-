using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoding
{
    
        public static class Base62
        {
            private static readonly char[] Base62Chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();

            public static string Encode(long key)
            {
                if (key < 0)
                    throw new ArgumentException("key must be a positive integer");

                var sb = new StringBuilder();
                do
                {
                    var mod = key % 62;
                    sb.Insert(0, Base62Chars[mod]);
                    key /= 62;
                } while (key > 0);
                while (sb.Length < 7)
                {
                    sb.Insert(0, '0');
                }

            return sb.ToString();
            }

            public static long Decode(string key)
            {
                if (string.IsNullOrEmpty(key))
                    throw new ArgumentException("key must not be empty");

                long result = 0;
                for (int i = 0; i < key.Length; i++)
                {
                    result = result * 62 + GetIndex(key[i]);
                }
                return result;
            }

            private static int GetIndex(char c)
            {
                for (int i = 0; i < Base62Chars.Length; i++)
                {
                    if (Base62Chars[i] == c)
                        return i;
                }
            throw new ArgumentException("key must be a positive integer");
        }
        }
    }


