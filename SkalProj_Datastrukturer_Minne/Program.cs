using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}

            
            
            //Min kod börjar här:
            List<string> theList = new List<string>();
            while (true)
            {
                // Läs användarens input
                Console.WriteLine("Enter +<name> to add or -<name> to remove (or type 'exit' to quit):"); 
                string input = Console.ReadLine();

                // Här kontrollerar jag om användaren vill avsluta
                if (input.ToLower() == "exit")
                {
                    break;
                }

                // Kontrollera att input inte är tom
                if (string.IsNullOrEmpty(input) || input.Length < 2)
                {
                    Console.WriteLine("Invalid input. Please use +<name> or -<name>.");
                    continue;
                }

                //Identifiera vilken operation som ska utföras (lägga till eller ta bort) och vilket värde som är relevant för operationen
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    // Lägg till information i listan
                    case '+':
                        theList.Add(value);
                        break;
                    // Ta bort information från listan
                    case '-':
                        theList.Remove(value);
                        break;
                    // Hantera felanvändning
                    default:
                        Console.WriteLine("Invalid operation. Please use only +<name> or -<name>.");
                        continue;
                }

                // Visa antal element och listans kapacitet 
                Console.WriteLine($"Count: {theList.Count}, Capacity: {theList.Capacity}");

            }


            //Frågorna besvaras här:
            /* 2. När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)
             * Listans kapacitet ökar när antalet element (Count) överstiger den nuvarande kapaciteten.
             * Detta händer vid nummer 4. 
             */

            /* 3. Med hur mycket ökar kapaciteten?
             * Kapaciteten ökar från 4 till 8, alltså fördubblas
             */

            /* 4. Varför ökar inte listans kapacitet i samma takt som element läggs till?
             * Kapaciteten ökar inte i samma takt som element läggs till för att kan vara 
             * kostsamt när det gäller prestanda. Genom att fördubbla kapaciteten minimerar 
             * listan antalet gånger den behöver allokera om och kopiera element till en ny 
             * array, vilket förbättrar prestandan.
             */

            /* 5. Minskar kapaciteten när element tas bort ur listan?
             * Kapaciteten minskar inte när element tas bort.
             */

            /* 6. När är det fördelaktigt att använda en egendefinierad array istället för en lista?
             * Det kan vara fördelaktigt att använda en egendefinierad array när man t.ex.
             * vet det exakta antalet element man behöver, och detta antal inte kommer att förändras.
             */
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */


            //Min kod börjar här:
            Queue<string> queue = new Queue<string>(); // Jag skapar en Queue<string> för kön
            bool exit = false;

            while (!exit) // jag initierar en loop som håller programmet igång tills användaren avslutar
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till i kön (enqueue)");
                Console.WriteLine("2. Ta bort från kön (dequeue)");
                Console.WriteLine("3. Visa kön");
                Console.WriteLine("4. Avsluta");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1": // Lägger till en person i kön med Enqueue
                        Console.Write("Ange namnet på personen som ska ställa sig i kön: ");
                        string name = Console.ReadLine();
                        queue.Enqueue(name);
                        Console.WriteLine($"{name} har ställt sig i kön.");
                        break;

                    case "2": // Tar bort en person från kön med Dequeue
                        if (queue.Count > 0)
                        {
                            string dequeuedName = queue.Dequeue();
                            Console.WriteLine($"{dequeuedName} har lämnat kön.");
                        }
                        break;

                    case "3": // Visar nuvarande kön
                        Console.WriteLine("Nuvarande kö: ");
                        foreach (string person in queue)
                        {
                            Console.WriteLine(person);
                        }
                        break;

                    case "4": // Avslutar programmet
                        exit = true;
                        break;

                    default :
                        Console.WriteLine("Valet var ogiltigt.");
                        break;
                }

            }

            // Simulering av ICA kön:
            /*ICA öppnar och kön till kassan är tom.
                Kalle ställer sig i kön.
                Kö: [Kalle]
                Greta ställer sig i kön.
                Kö: [Kalle, Greta]
                Kalle blir expedierad och lämnar kön.
                Kö: [Greta]
                Stina ställer sig i kön.
                Kö: [Greta, Stina]
                Greta blir expedierad och lämnar kön.
                Kö: [Stina]
                Olle ställer sig i kön.
                Kö: [Stina, Olle]
             */

        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        //1.Simulera ännu en gång ICA-kön på papper. Denna gång med en stack.
        //Varför är det inte så smart att använda en stack i det här fallet? 

        /*ICA öppnar och stacken är tom.
            Kalle ställer sig i kön (pushas till stacken).
            Stack: [Kalle]
            Greta ställer sig i kön (pushas till stacken).
            Stack: [Kalle, Greta]
            Greta blir expedierad och lämnar kön (poppas från stacken).
            Stack: [Kalle]
            Stina ställer sig i kön (pushas till stacken).
            Stack: [Kalle, Stina]
            Stina blir expedierad och lämnar kön (poppas från stacken).
            Stack: [Kalle]
            Olle ställer sig i kön (pushas till stacken).
            Stack: [Kalle, Olle]
         */

        /*Med en stack blir ordningen omvänd jämfört med hur en kö ska fungera. 
         *Greta och Stina, som ställde sig i kön efter Kalle, blev expedierade före honom, 
         *vilket inte är en logisk eller rättvis ordning för att hantera köer som t.ex. en ICA-kassa kö.
         */


        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

