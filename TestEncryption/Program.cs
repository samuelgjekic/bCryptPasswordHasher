
using BCrypt;

namespace PasswordHasher
{

    public class Program
    {
        // We create a instance of the Encryption object
        private static Encryption encrypt = new Encryption();


        static bool isActive = true; // Defines if program is running
        public static void Main(string[] args)
        {
            MainMenu();
        }
        public static void MainMenu()
        { // Main Console Menu
  
            while (isActive) 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\t Bcrypt Password Hasher by Samuel Gjekic");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t1. Create password hash");
               Console.WriteLine("\t2. Verify password hash");
               Int32.TryParse(Console.ReadLine(), out int val);
                switch(val)
                {
                    case 1:// Hash a password with Bcrypt hasher
                        Console.WriteLine("\n\t Enter a password:");
                        string password = Console.ReadLine();
                        if (password != "")
                        {
                            string hashedPassword = encrypt.EncryptPassword(password);
                            Console.WriteLine("\n\tPassword Hash: " + hashedPassword);
                            Console.WriteLine("\n\tPress enter to return to the menu...");

                        }
                        else if (password == "")
                        {
                            Console.WriteLine("\t You entered null!");
                            Console.WriteLine("\n\tPress enter to return to the menu...");
                        }


                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case 2: // Compare a password and a password hash and return true or false
                        Console.WriteLine("\n\t Enter a password:");
                        string verifyPassowrd = Console.ReadLine();
                        Console.WriteLine("\t Enter the password hash:");
                        string VerifyHash = Console.ReadLine();
                        bool isValid = encrypt.VerifyPassword(verifyPassowrd, VerifyHash); // Validate the password with the hash and return to bool
                        if (isValid)
                        {
                            Console.WriteLine("\n\t Password and hash matched.");
                            Console.WriteLine("\t Press enter to return to the menu...");
                            Console.ReadLine();
                            Console.Clear();
                        } else if (!isValid) 
                        {
                            Console.WriteLine("\n\t Password and hash did NOT match.");
                            Console.WriteLine("\t Press enter to return to the menu...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    default:
                        Console.WriteLine("\n\tPlease enter a value...");
                        break;
                }

            }
        }
    }
}