using System;
using System.Text;

namespace Core.Utilities.Hashing
{
    public class HashingHelper
    {
        public static void CreatePassword(string password, out byte[] passwordHash, out byte[] passwordSalt)//out keywordü ile parametreleri geri döndürdük.
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            if (string.IsNullOrEmpty(password)) return false;
            if (password.Length < 4) return false;
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computeHash.Length; i++)
                {
                    if (computeHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

