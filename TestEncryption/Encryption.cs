using BCrypt;
using BCrypt.Net;

namespace PasswordHasher
{
    public class Encryption
    {
        public Encryption()
        { // Constructor
        }

        public string EncryptPassword(string _password)
        {
            try
            {
                string _salt = BCrypt.Net.BCrypt.GenerateSalt(); // Generate Salt
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(_password, _salt); // Encrypt the password using BCrypt hasher.
                return hashedPassword; // Return the hash
            } catch (Exception ex) 
            {
                return "Error with Encryption!";
                throw new Exception(ex.Message);
            }
            
        }
        
        public bool VerifyPassword(string _password, string _hash)  // Recieve a password and a hash
        {
            try
            {
                bool validPassword = BCrypt.Net.BCrypt.Verify(_password, _hash); // Check the user input with hashcode from DB Table
                return validPassword; // Return True for valid or false for non valid

            }
            catch (Exception ex)
            {
                Console.WriteLine("error!: " + ex.Message);
            }
            return false; // Return True for valid or false for non valid!
        }
    }
}
