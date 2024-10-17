using System.Text.RegularExpressions;

        string teststr1 = "The quick brown Fox jumps over the lazy Dog";

        // Create a Regex pattern to match words that start with an uppercase letter
        Regex CapWords = new Regex(@"[A-Z]\w+");

        // TODO: Regular expressions can be used to replace content in strings
        // in addition to just searching for content

        // Simple replace: Replace all words that start with a capital letter with "REPLACED"
        string replacedStr = CapWords.Replace(teststr1, "REPLACED");
        Console.WriteLine("Simple replacement result:");
        Console.WriteLine(replacedStr);

        // TODO: Replacement text can be generated on the fly using MatchEvaluator
        // This is a delegate that computes the new value of the replacement

        // Use MatchEvaluator directly as a delegate without defining a method
        string replacedWithMatchEval = CapWords.Replace(teststr1, match =>
        {
            // Convert the matched word to lowercase
            return match.Value.ToLower();
        });

        Console.WriteLine("\nDynamic replacement result:");
        Console.WriteLine(replacedWithMatchEval);