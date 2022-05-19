using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passworHash, out byte[] passworSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passworSalt = hmac.Key;
                passworHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] passworHash, byte[] passworSalt) 
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passworSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!= passworHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
