// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for using Regex to find patterns
using System.Text.RegularExpressions;

        string teststr1 = "The quick brown Fox jumps over the lazy Dog";
        string teststr2 = "the quick brown fox jumps over the lazy dog";

        // Define a regex pattern to match the word "fox"
        string pattern = @"fox";

        // TODO: The IsMatch function is used to determine if the content of a string
        // results in a match with the given Regex
        bool isMatch1 = Regex.IsMatch(teststr1, pattern);
        bool isMatch2 = Regex.IsMatch(teststr2, pattern);
        Console.WriteLine($"Is 'fox' found in teststr1? {isMatch1}");
        Console.WriteLine($"Is 'fox' found in teststr2? {isMatch2}");

        // TODO: The RegexOptions argument can be used to perform
        // case-insensitive searches
        bool isMatchCaseInsensitive1 = Regex.IsMatch(teststr1, pattern, RegexOptions.IgnoreCase);
        bool isMatchCaseInsensitive2 = Regex.IsMatch(teststr2, pattern, RegexOptions.IgnoreCase);
        Console.WriteLine($"Is 'fox' found in teststr1 (case-insensitive)? {isMatchCaseInsensitive1}");
        Console.WriteLine($"Is 'fox' found in teststr2 (case-insensitive)? {isMatchCaseInsensitive2}");

        // Use the Match and Matches methods to get information about
        // specific Regex matches for a given pattern

        // TODO: The Match method returns a single match at a time
        Match match1 = Regex.Match(teststr1, pattern, RegexOptions.IgnoreCase);
        if (match1.Success)
        {
            Console.WriteLine($"Match found in teststr1: {match1.Value} at position {match1.Index}");
        }

        // TODO: The Matches method returns a collection of Match objects
        MatchCollection matches2 = Regex.Matches(teststr2, pattern, RegexOptions.IgnoreCase);
        foreach (Match match in matches2)
        {
            Console.WriteLine($"Match found in teststr2: {match.Value} at position {match.Index}");
        }