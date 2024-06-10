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
            
            
            //1.Simulera ännu en gång ICA-kön på papper. Denna gång med en stack.
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

            //Varför är det inte så smart att använda en stack i det här fallet? 
            /*Med en stack blir ordningen omvänd jämfört med hur en kö ska fungera. 
             *Greta och Stina, som ställde sig i kön efter Kalle, blev expedierade före honom, 
             *vilket inte är en logisk eller rättvis ordning för att hantera köer som t.ex. en ICA-kassa kö.
             */

            // Min kod börjar här:
            Stack<char> stack = new Stack<char>(); // Skapar en ny stack för tecken
            string input;
            bool exitLoop = false;

            while (!exitLoop) // Loopen körs tills användaren väljer att avsluta
            {
                Console.WriteLine("1. Pusha tecken till stacken");
                Console.WriteLine("2. Poppa tecken från stacken");
                Console.WriteLine("3. Skriv ut stacken");
                Console.WriteLine("4. Anropa Reverse metoden");
                Console.WriteLine("5. Avsluta");
                Console.Write("Välj ett alternativ: ");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1": // Pusha tecken till stacken
                        Console.Write("Ange tecken att pusha: ");
                        char charToPush = Console.ReadKey().KeyChar; // Läsa in ett enskilt tecken från användaren och lagra det i variabeln charToPush av typen char
                        Console.WriteLine();
                        stack.Push(charToPush);  // Lägger till tecknet överst på stacken
                        break;

                    case "2": // Poppa tecken från stacken
                        if (stack.Count > 0)
                        {
                            char poppedChar = stack.Pop(); // Tar bort och returnerar tecknet överst på stacken
                            Console.WriteLine($"Poppade tecknet: {poppedChar}");
                        }
                        else
                        {
                            Console.WriteLine("Stacken är tom");
                        }
                        break;

                    case "3": // Skriv ut stacken
                        Console.WriteLine("Stacken innehåller: ");
                        foreach (char x in stack) // Itererar över stacken och skriver ut varje tecken
                        {
                            Console.Write(x + "");
                        }
                        Console.WriteLine();
                        break;

                    case "4": // Anropa Reverse metoden
                        ReverseText(); // metoden är inte färdigkodad ännu.
                        break;

                    case "5": // Avsluta
                        exitLoop = true;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            } 
        }

        static void ReverseText()
        {
            Console.Write("Ange en sträng att vända: ");
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>(); // Skapar en ny stack för tecken

            foreach (char i in input)
            {
                stack.Push(i);
            }

            string reversedString = ""; // Tom sträng för att lagra den omvända strängen

            while (stack.Count > 0)
            {
                reversedString += stack.Pop(); // Poppa varje tecken från stacken och lägg till det i den omvända strängen
            }

            Console.WriteLine($"Omvänd sträng: {reversedString}"); // Skriva ut den omvända strängen
        }




        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            /*1.Skapa med hjälp av er nya kunskap funktionalitet för att kontrollera en välformad sträng på papper. 
             * Du ska använda dig av någon eller några av de datastrukturer vi precis gått igenom. 
             * Vilken datastruktur använder du?
             * 
             * Svar:
             * Jag skulle använda en stack eftersom den följer LIFO principen, alltså "Last In, First Out".
             * Detta innebär att det senaste elementet som lagts till är det första som tas bort.
             * I vårt fall med parenteser funkar det bra för att matcha öppna och stängda parenteser.
             */

            // Min kod börjar här:

            Console.WriteLine("Ange en sträng för att kontrollera om den är välformad:"); // Be användaren att ange en sträng
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>(); // Stack för öppna parenteser

            foreach (char z in input)  // Gå igenom varje tecken i strängen
            {
                if (z == '(' || z == '{' || z == '[') // Om tecknet är en öppen parentes, läggs den till i stacken
                {
                    stack.Push((char)z);
                }

                else if (z == ')' || z == '}' || z == ']') // Om tecknet är en stängd parentes, kontrollera om den matchar den senaste öppnande parentesen
                {
                    if (stack.Count == 0) // Om stacken är tom, finns det ingen matchande öppen parentes
                    {
                        Console.WriteLine("Strängen är inte välformad.");
                        return;
                    }

                    char lastOpen = stack.Pop(); // Ta bort den senaste öppnande parentesen från stacken

                    // Kontrollera om den senaste öppnande parentesen matchar den stängande parentesen
                    if ((z == ')' && lastOpen != '(') ||
                    (z == '}' && lastOpen != '{') ||
                    (z == ']' && lastOpen != '['))
                    {
                        Console.WriteLine("Strängen är inte välformad.");
                        return;
                    }
                }
            }

            // Om stacken inte är tom, finns det öppna parenteser som inte har stängts
            if (stack.Count == 0)
            {
                Console.WriteLine("Strängen är välformad.");
            }
            else
            {
                Console.WriteLine("Strängen är inte välformad.");
            }

        }




    }
}

