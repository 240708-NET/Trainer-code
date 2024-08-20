using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

public class HashingService : IHashingService{
    public string HashPassword(string password)
    {
       // Generate a 128-bit salt using a cryptographically strong random number generator
        byte[] salt = new byte[128 / 8];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(salt);
        }

        // Derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
        string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));

        // Combine salt and hashed password
        string combinedHash = $"{Convert.ToBase64String(salt)}:{hashed}";

        return combinedHash;

    }

    public bool VerifyHashedPassword(string hashedPassword, string passwordToCheck){
         // Extract salt and hash from stored password hash
      // Extract salt and hash from stored password hash
        string[] parts = hashedPassword.Split(':');
        if (parts.Length != 2)
        {
            throw new ArgumentException("Invalid hashed password format");
        }

        byte[] salt = Convert.FromBase64String(parts[0]);
        string storedHash = parts[1];

        // Compute the hash of the provided password with the extracted salt
        string computedHash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: passwordToCheck,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));

        // Compare the computed hash with the stored hash
        return storedHash.Equals(computedHash);
    }



}