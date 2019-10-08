using System;

namespace is_authorized
{
    class Program
    {
        static string correctPassword1 = "sten";
        static string correctPassword2 = "sjö";
        static string correctPassword3 = "skog";
        static string inputPassword1;
        static string inputPassword2;
        static string inputPassword3;

        static bool IsAuthorized()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Lösenord 1: ");
                inputPassword1 = Console.ReadLine();
                Console.Write("Lösenord 2: ");
                inputPassword2 = Console.ReadLine();
                Console.Write("Lösenord 3: ");
                inputPassword3 = Console.ReadLine();

                if (correctPassword1 == inputPassword1 && correctPassword2 == inputPassword2 && correctPassword3 == inputPassword3)
                {
                    return true;
                }
                else if (i == 5)
                {

                    return false;
                }
            }
            return false;
        }

        static void IfPasswordIsCorrect(bool password)
        {
            if (password == true)
            {
                Console.WriteLine("Lösenorden är rätt!");
            }
            else
            {
                Console.WriteLine("Fel lösenord!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in dina 3 lösenord för att logga in");
            bool password = IsAuthorized();
            IfPasswordIsCorrect(password);
        }
    }
}
