using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void parseStringToUserAndPasswordDictionary(string input, ref Dictionary<string, string> usersDatabase)
        {
            char[] delimiters = " ->".ToCharArray();
            string[] userAndPassword = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            string name = userAndPassword.First();
            string password = userAndPassword.Last();
            usersDatabase[name] = password;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> userDatabase = new Dictionary<string, string>();
            int unsuccessifulLogins = 0;
            while (input != "login" && input != "end")
            {
                parseStringToUserAndPasswordDictionary(input, ref userDatabase);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "end")
            {
                Dictionary<string, string> currentLoginAttempt = new Dictionary<string, string>();
                parseStringToUserAndPasswordDictionary(input, ref currentLoginAttempt);
                string currUser = currentLoginAttempt.Keys.First() ;
                string currPassword = currentLoginAttempt.Values.First();
                if (userDatabase.ContainsKey(currUser))
                {
                    if (userDatabase[currUser] == currPassword)
                    {
                        Console.WriteLine($"{currUser}: logged in successfully");
                    }
                    else
                    {
                        ++unsuccessifulLogins;
                        Console.WriteLine($"{currUser}: login failed");
                    }
                }
                else
                {
                    ++unsuccessifulLogins;
                    Console.WriteLine($"{currUser}: login failed");
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {unsuccessifulLogins}");
        }
    }
}
