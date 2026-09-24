using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        /*
        EXCEEDING REQUIREMENTS / CREATIVITY:
        1. Scripture Library: Included a list of multiple scriptures (both single verse and verse ranges). 
            The program randomly selects one scripture from the library each time it runs.
        2. Smart Word Hiding: The algorithm in Scripture.HideRandomWords strictly targets words that 
            are NOT already hidden, preventing wasted cycles on already-hidden words and ensuring smooth progress.
        */
    // Exceeding Requirements: Make a library of a lot of scripture
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy.")
        };

        // Choose random scripture
        Random random = new Random();
        Scripture currentScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        while (true)
        {
            Console.Clear(); // Make screen clear
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine();

            if (currentScripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // hide three words every time tap enter
            currentScripture.HideRandomWords(3);
        }
    }
}