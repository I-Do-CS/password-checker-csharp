namespace PasswordChecker
{
    class Program
    {
        static void Main()
        {
            // Ask user for a password
            Console.Write("Enter Password: ");
            string? password = Console.ReadLine();

            if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Invalid Password, Try again.");
                Main();
                return;
            }

            Console.Write("Confirm Password: ");
            string? confirmPassword = Console.ReadLine();

            if (password.Equals(confirmPassword))
            {
                Console.WriteLine("Passwords Match. Thanks!");
            }
            else
            {
                Console.WriteLine("Passwords do not match, Try again.");
                Main();
                return;
            }

            return;
        }
    }
}