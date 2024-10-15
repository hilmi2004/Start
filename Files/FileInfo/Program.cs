// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Working with file information

// Make sure the example file exists
const string filename = "TestFile.txt";

if (!File.Exists(filename)) {
    using (StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file.");
        sw.WriteLine("This is a text file in a database in factoryreset");
        
    }
}

// TODO: Get some information about the file
Console.WriteLine(File.GetCreationTime(filename));
Console.WriteLine(File.GetLastWriteTime(filename));
Console.WriteLine(File.GetLastAccessTime(filename));

// TODO: We can also get general information using a FileInfo 


// TODO: File information can also be manipulated

