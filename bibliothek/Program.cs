using bibliothek;

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
                        ShowAddBookMenu();
                        break;

                    case "2":
                        Console.WriteLine("[Aktion] Add DVD wird ausgeführt...");
                        ShowAddDVDMenu();
                        break;

                    case "3":
                        Console.WriteLine("[Aktion] Add Member wird ausgeführt...");
                        ShowAddMemberMenu();
                        break;

                    case "4":
                        Console.WriteLine("[Aktion] List All Items wird ausgeführt...");
                        ShowListAllItems();
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

        public static void ShowAddBookMenu()
        {
            bool inBookMenu = true;
            while (inBookMenu)
            {
                Console.Clear();
                Console.WriteLine("________________________________________");
                Console.WriteLine("              ADD BOOK MENU             ");
                Console.WriteLine("________________________________________");
                Console.WriteLine("1. Add Standard Book");
                Console.WriteLine("2. Add Audio Book");
                Console.WriteLine("3. <-- Back to Main Menu");
                Console.WriteLine("________________________________________");
                Console.Write("please select (1-3): ");


                string bookChoice = Console.ReadLine();
                Console.Clear();


                switch (bookChoice)
                {
                    case "1":
                        Console.WriteLine("--- Add Standard Book ---");
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();


                        Console.WriteLine("\nSucces: Book added!");


                        Console.WriteLine("\nPress any key to return to the Add Book Menu...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("--- add Audio Book ---");
                        Console.Write("Enter Title: ");
                        string audiotitle = Console.ReadLine();
                        Console.Write("Enter Narrator: ");
                        string narrator = Console.ReadLine();


                        Console.WriteLine("\nSucces: Audio Book added!");


                        Console.WriteLine("\nPress any key to return to the Add Book Menu...");
                        Console.ReadKey();
                        break;

                    case "3":
                        inBookMenu = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option! Please enter a number between 1 and 3.");
                        Console.WriteLine("\nPress any key to return to the Add Book Menu...");
                        Console.ReadKey();
                        break;


                }


            }

        }

        public static void ShowAddDVDMenu()
        {
            bool inDVDMenu = true;
            while (inDVDMenu)
            {
                Console.Clear();
                Console.WriteLine("________________________________________");
                Console.WriteLine("              ADD DVD MENU             ");
                Console.WriteLine("________________________________________");
                Console.WriteLine("1. Add Movie  DVD");
                Console.WriteLine("2. Add Documentary DVD");
                Console.WriteLine("3. <-- Back to Main Menu");
                Console.WriteLine("________________________________________");
                Console.Write("please select (1-3): ");


                string dvdChoice = Console.ReadLine();
                Console.Clear();

                switch (dvdChoice)
                {
                    case "1":
                        Console.WriteLine("--- Add Movie DVD ---");
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Director: ");
                        string director = Console.ReadLine();
                        Console.Write("Enter Duration ");
                        string duration = Console.ReadLine();



                        Console.WriteLine("\nSucces: Movie DVD added!");


                        Console.WriteLine("\nPress any key to return to the Add DVD Menu...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("--- Add Documentary DVD ---");
                        Console.Write("Enter Title: ");
                        string docTitle = Console.ReadLine();
                        Console.Write("Enter Topic: ");
                        string docTopic = Console.ReadLine();
                        Console.Write("Enter Duration: ");
                        string docDuration = Console.ReadLine();


                        Console.WriteLine("\nSuccess: Documentary DVD added!");


                        Console.WriteLine("\nPress any key to return to the Add DVD Menu...");
                        Console.ReadKey();
                        break;

                    case "3":

                        inDVDMenu = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option! Please enter a number between 1 and 3.");
                        Console.WriteLine("\nPress any key to return to the Add DVD Menu...");
                        Console.ReadKey();
                        break;

                }

            }
        }
        public static void ShowAddMemberMenu()
        {
            bool inMemberMenu = true;
            while (inMemberMenu)
            {
                Console.Clear();
                Console.WriteLine("________________________________________");
                Console.WriteLine("              ADD MEMBER MENU           ");
                Console.WriteLine("________________________________________");
                Console.WriteLine("1. Add Regular Member");
                Console.WriteLine("2. Add Premium Member");
                Console.WriteLine("3. <-- Back to Main Menu");
                Console.WriteLine("________________________________________");
                Console.Write("please select (1-3): ");


                string memberChoice = Console.ReadLine();
                Console.Clear();


                switch (memberChoice)
                {
                    case "1":
                        Console.WriteLine("--- Add Regular Member ---");
                        Console.Write("Enter First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Enter Last Name: ");
                        string lastName = Console.ReadLine();


                        Console.WriteLine("\nSuccess: Regular Member added!");

                        Console.WriteLine("\nPress any key to return to the Add Member Menu...");
                        Console.ReadKey();
                        break;

                    case "2":

                        Console.WriteLine("--- Add Premium Member ---");
                        Console.Write("Enter Full Name: ");
                        string premiumName = Console.ReadLine();
                        Console.Write("Enter Membership duration (in months): ");
                        string duration = Console.ReadLine();


                        Console.WriteLine("\nSuccess: Premium Member added!");


                        Console.WriteLine("\nPress any key to return to the Add Member Menu...");
                        Console.ReadKey();
                        break;

                    case "3":
                        inMemberMenu = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option! Please enter a number between 1 and 3.");
                        Console.WriteLine("\nPress any key to return to the Add Member Menu...");
                        Console.ReadKey();
                        break;






                }
            }
        }

        public static void ShowListAllItems()
        {
            LibraryItem media = new();

            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("        ALL LIBRARY ITEMS    ");
            Console.WriteLine("=============================");


            Console.WriteLine("\n--- BOOKS ---");
            if (media.BookList.Count == 0) Console.WriteLine("No books found.");
            else foreach (string book in media.BookList) Console.WriteLine("- " + book);


            Console.WriteLine("\n--- DVDs ---");
            if (media.DVDList.Count == 0) Console.WriteLine("No DVDs found");
            else foreach (string dvd in media.DVDList) Console.WriteLine("- " + dvd);


            Console.WriteLine("\n--- MEMBERS ---");
            if (media.MemberList.Count == 0) Console.WriteLine("No members found.");
            else foreach (string member in media.MemberList) Console.WriteLine("-" + member);


            Console.WriteLine("\n=========================================");
            Console.WriteLine("Press any key to return to main Menu...");
            Console.ReadKey();
        }
    }
}
























