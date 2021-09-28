using System;

namespace LoginCredentials
{
    class Program
    {
        public static string Password { get; private set; }

        static void Main(string[] args)
        {
            /*Login Form
             * login: user
             * password: user1234
             * Create a program that asks user's login credentials
             * Check if the user entered correct login and password
             * If the login and password are correct display 'Welcome'
             * If the login or password are incorrect dispay 'try again'
             
             */
            string Login;
            string Password;
            Console.WriteLine("Login: ");
            Login = Console.ReadLine();
            Console.WriteLine("Password: ");
            Password = Console.ReadLine();

            if ((Login == "user") && (Password == "user1234"))
            {
                Console.WriteLine("The login is correct, please welcome!");
            }
            if ((Login == "admin1") && (Password == "pass12345"))
            {
                Console.WriteLine("The password is incorrect, please try again!");
            }
            if  ((Login == "user") && (Password == "user1234"))
            {
                Console.WriteLine("Welcome.");
            }
            if ((Login == "admin1") && (Password == "pass12345"))
            {
                Console.WriteLine("kai vittu");
            }
        }
    }
}
