
using System.Text.RegularExpressions;
using System.Diagnostics;

const string thestr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

// Use a Stopwatch to show elapsed time
Stopwatch sw;

// Set a timeout value for the regular expression execution
TimeSpan timeout = TimeSpan.FromMilliseconds(100); // Adjust as needed

try {
    sw = Stopwatch.StartNew();
    // Pass the timeout value to the Regex constructor
    Regex CapWords = new Regex(@"(a+a+)+b", RegexOptions.None, timeout);
    MatchCollection mc = CapWords.Matches(thestr);
    sw.Stop();
    Console.WriteLine($"Found {mc.Count} matches in {sw.Elapsed} time:");
    foreach (Match match in mc) {
        Console.WriteLine($"'{match.Value}' found at position {match.Index}");
    }
}
catch (RegexMatchTimeoutException e) {
    // Handle the timeout exception
    Console.WriteLine($"Regex timed out after {timeout.TotalMilliseconds}ms: {e.Message}");
}
catch (Exception e) {
    Console.WriteLine(e);
}
