using System;
using System.Text;

namespace Practice_dot_net.Security
{
    public class Crypt
    {
        private const byte _num = 3;
        public static string EnCrypt(string message)
        {
            StringBuilder strinBuilder = new StringBuilder();
            foreach(var letter in message)
            {
                char temp = (char)((int)letter + _num);
                strinBuilder.Append(temp);
            }
            return strinBuilder.ToString();
        }
        public static string DeCrypt(string message)
        {
            StringBuilder strinBuilder = new StringBuilder();
            foreach (var letter in message)
            {
                char temp = (char)((int)letter - _num);
                strinBuilder.Append(temp);
            }
            return strinBuilder.ToString();
        }
    }
}

