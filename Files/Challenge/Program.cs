// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



string firstpath = "FileCollection";
string secondpath = "Results.txt";

string ext;

bool iscompatibleext(ext)
{
    return ext == ".docx" || ext == ".xlsx" || ext == ".pptx";
}

int doccount, totalcount, pptcount, xlscount;
long docsize, totalsize , pptsize; xlssize;

DirectoryInfo directoryInfo = new DirectoryInfo(firstpath);

foreach(FileInfo fileInfo in directoryInfo.GetFiles())
{
    if (iscompatibleext(fileInfo.Extension()){
        totalcount++;
        totalsize = fileInfo.Length;

        if (fileInfo.Extension == ".docx")
        {
            doccount++;
            docsize = fileInfo.Length;


        }
        if (fileInfo.Extension == ".xlsx")
        {
            xlscount++;
            xlssize = fileInfo.Length;
        }
        if (fileInfo.Extension == ".pptx")
        {
            pptcount++;
            pptsize = fileInfo.Length;
        }
    }



}

using (StreamWriter sw = new StreamWriter(secondpath))
{
    sw.WriteLine("print all the results like count and size");
}