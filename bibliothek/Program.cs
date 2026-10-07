namespace Bibliothek
{
    class Bibliothek
    {

        Dictionary<int, string> idVerteilung = new()
        {
            [1] = "Ali",
        };

        static void Main(string[] args)
        {
            // Variablen
            bool laeuft = true;

            while (laeuft)
            {

                HauptMenueAusgeben();

                string? eingabe = Console.ReadLine();
                Console.WriteLine();


                switch (eingabe)
                {
                    case "1":
                        Console.WriteLine("[Aktion] Add Book wird ausgeführt...");

                        break;

                    case "2":
                        Console.WriteLine("[Aktion] Add DVD wird ausgeführt...");

                        break;

                    case "3":
                        Console.WriteLine("[Aktion] Add Member wird ausgeführt...");

                        break;

                    case "4":
                        Console.WriteLine("[Aktion] List All Items wird ausgeführt...");

                        break;

                    case "5":
                        Console.WriteLine("[Aktion] Search Item by Title wird ausgeführt...");

                        break;

                    case "6":
                        Console.WriteLine("[Aktion] Borrow Item wird ausgeführt...");

                        break;

                    case "7":
                        Console.WriteLine("[Aktion] Return Item wird ausgeführt...");

                        break;

                    case "8":

                        Console.WriteLine("Exiting Library Manager. goodbye");
                        laeuft = false;
                        break;

                    default:

                        Console.WriteLine("Invalid option! Please enter a number between 1 and 8.");
                        break;
                }
            }
        }

        public static void HauptMenueAusgeben()
        {
            Console.WriteLine("=== Library Manager ===");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Add DVD");
            Console.WriteLine("3. Add Member");
            Console.WriteLine("4. List all items");
            Console.WriteLine("5. Search item by title");
            Console.WriteLine("6. Borrow item");
            Console.WriteLine("7. Return item");
            Console.WriteLine("8. Exit");
            Console.Write("\nChoose an option (1-8): ");
        }

        static void ShowAddBookMenu()
        {
            bool inBookMenu = true;
            while (inBookMenu)
            {
                Console.Clear();
                Console.WriteLine("________________________________________");
                Console.WriteLine("              ADD BOOK MENU             ");

            }

        }
    }
}































