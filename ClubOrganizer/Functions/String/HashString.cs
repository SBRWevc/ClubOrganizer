using System;
using System.Security.Cryptography;
using System.Text;

namespace ClubOrganizer.Functions.String
{
    class HashString
    {
        internal static string? Hash(string password)
        {
            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = MD5.HashData(b);

            StringBuilder sb = new();
            foreach (var a in hash)
            {
                sb.Append(a.ToString("X2"));
            }

            return Convert.ToString(sb);
        }
    }
}
