
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
                Console.WriteLine("\t###########################################\n\t Bcrypt Password Hasher by Samuel Gjekic \n\t########################################### \n \n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1. Create password hash");
               Console.WriteLine("2. Verify password hash");
               Int32.TryParse(Console.ReadLine(), out int val);
                switch(val)
                {
                    case 1:// Hash a password with Bcrypt hasher
                        Console.WriteLine("Enter a password:");
                        string password = Console.ReadLine();
                        if (password != "")
                        {
                            string hashedPassword = encrypt.EncryptPassword(password);
                            Console.WriteLine("Password Hash: " + hashedPassword);
                            Console.WriteLine("Press enter to return to the menu...");

                        }
                        else if (password == "")
                        {
                            Console.WriteLine("You entered null!");
                            Console.WriteLine("Press enter to return to the menu...");
                        }


                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case 2: // Compare a password and a password hash and return true or false
                        Console.WriteLine("Enter a password:");
                        string verifyPassword = Console.ReadLine();
                        Console.WriteLine("Enter the password hash:");
                        string VerifyHash = Console.ReadLine();
                        bool isValid = encrypt.VerifyPassword(verifyPassword, VerifyHash); // Validate the password with the hash and return to bool
                        if (isValid)
                        {
                            Console.WriteLine("Password and hash matched.");
                            Console.WriteLine("Press enter to return to the menu...");
                            Console.ReadLine();
                            Console.Clear();
                        } else if (!isValid) 
                        {
                            Console.WriteLine("Password and hash did NOT match.");
                            Console.WriteLine("Press enter to return to the menu...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter a value...");
                        break;
                }

            }
        }
    }
}