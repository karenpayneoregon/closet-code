using ExceptionsWhenApp.Classes;

namespace ExceptionsWhenApp;

partial class Program
{
    static async Task Main(string[] args)
    {

        var (list, exception) = FileOperations.ReadFileConventional("TextFile1.txt");
        WriteLineForContinue("Lines in file");
        if (exception is null)
        {
            list.ToList().ForEach(Console.WriteLine);
        }
        else
        {
            Console.WriteLine(exception.Message);
        }

        WriteLineForContinue("File missing");

        var ( _ , message) = FileOperations.ReadFileWithWhenFilter("NoneExistingFile.txt");
        Console.WriteLine(message);

        WriteLineForContinue("File locked");
        FileStream s2 = new FileStream("TextFile1.txt", FileMode.Open, FileAccess.Read, FileShare.None);
        var (_, message2) = FileOperations.ReadFileWithWhenFilter("TextFile1.txt");
        Console.WriteLine(message2);


        WriteLineForContinue("Page not found");
        var result = await WebOperations.MakeRequestWithWhenFilter("https://google.com/111");
        Console.WriteLine(result);

        WriteLineForContinue("fall through (wait for it)");
        result = await WebOperations.MakeRequestWithWhenFilter();
        Console.WriteLine(result);
        Console.ReadLine();
    }


}