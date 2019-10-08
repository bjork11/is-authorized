using System;
using System.Collections.Generic;
using System.Linq;

namespace is_authorized
{
    //Googlade hur man soterar listor med string och hittade ett exempel på geeksforgeeks
    //https://www.geeksforgeeks.org/how-to-sort-list-in-c-sharp-set-1/
    //Fattar inte riktigt hur comparern används eller varför dock!

   /*  class CFG : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            return x.CompareTo(y);
        }
    }*/
    class Program
    {
        //För att programmet ska fungera i nuläget måste correctPassword vara sorterade i bokstavsordning.
        //Det går att göra en lista till för att sortera även dessa men det känns inte nödvändigt för denna övningen.
        static string correctPassword1 = "!adam";
        static string correctPassword2 = "4dam";
        static string correctPassword3 = "adam";
        static string inputPassword1;
        static string inputPassword2;
        static string inputPassword3;
        //static CFG Comparer = new CFG();
        static List<string> userInputs = new List<string>();
        static bool IsAuthorized()
        {
            for (int i = 0; i < 5; i++)
            {
                userInputs.Clear();

                Console.Write("Lösenord 1: ");
                inputPassword1 = Console.ReadLine();
                Console.Write("Lösenord 2: ");
                inputPassword2 = Console.ReadLine();
                Console.Write("Lösenord 3: ");
                inputPassword3 = Console.ReadLine();

                //Lägger till inmatade lösenord i listan
                userInputs.Add(inputPassword1);
                userInputs.Add(inputPassword2);
                userInputs.Add(inputPassword3);
                //Sorterar listan med inmatade lösenord
                userInputs.Sort();

                //Returnerar true till Main om alla 3 lösenord stämmer, oavsett vilken ordning de matats in i
                if (correctPassword1 == userInputs[0] && correctPassword2 == userInputs[1] && correctPassword3 == userInputs[2])
                {
                    return true;
                }
                else if (i == 5)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Fel lösenord!");
                    Console.ReadLine();
                }
            }
            return false;
        }

        static void IfPasswordIsCorrect(bool password)
        {
            if (password == true)
            {
                Console.WriteLine("Lösenorden är rätt! \nDu har nu tillgång till hela innehållet i Pandoras Ask!");
            }
            else
            {
                Console.WriteLine("Du har skrivit fel lösenord 5 gånger. \n Innehållet i Pandoras Ask är nu för evigt oåtkomligt för dig!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Här ligger Pandoras Ask gömd!");
            Console.WriteLine("Skriv in rätt lösenord för att få tillgång till denna skatt.");
            bool password = IsAuthorized();
            IfPasswordIsCorrect(password);
        }
    }
}
