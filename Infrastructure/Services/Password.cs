using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Infrastructure.Services
{
    public static class Password
    {
        public static string GetRandomPassword()
        {
            string password = string.Empty;
            for (int i = 0; i < 7; i++)
                password += GetRandomChar(ref i, password);
            return password;
        }

        private static string GetRandomChar(ref int i, string password)
        {
            Random random = new Random();
            int codigo = random.Next(48, 122);
            return GetValidValidChar(ref i, password, codigo);
        }

        private static string GetValidValidChar(ref int i, string password, int codigo)
        {
            string result = string.Empty;
            string charPassword = ((char)codigo).ToString();
            if (password.Contains(charPassword))
                i--;
            else if ((codigo >= 48 && codigo <= 57) || (codigo >= 97 && codigo <= 122))
                result = charPassword;
            else
                i--;
            return result;
        }

        public static string GetMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

    }
}
