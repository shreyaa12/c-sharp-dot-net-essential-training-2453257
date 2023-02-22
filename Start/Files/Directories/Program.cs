// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

const string dirname = "TestDir";

// TODO: Create a Directory if it doesn't already exist
// if(!Directory.Exists(dirname)){
//     Directory.CreateDirectory(dirname);

// }
// else{
//     Directory.Delete(dirname);
// }

// TODO: Get the path for the current directory
string currPath = Directory.GetCurrentDirectory();
Console.WriteLine($"Current directory is {currPath}");


// TODO: Just like with files, you can retrieve info about a directory
DirectoryInfo di = new DirectoryInfo(dirname);
Console.WriteLine($"{di.Name}");
Console.WriteLine($"{di.Parent}");
Console.WriteLine($"{di.CreationTime}");

// TODO: Enumerate the contents of directories

Console.WriteLine("Just directories:");
List<string> thedirs = new List<string>(Directory.EnumerateDirectories(currPath));
foreach( string dir in thedirs){
    Console.WriteLine(dir);
}
Console.WriteLine("---------------");

Console.WriteLine("Just files:");
List<string> theFiles = new List<string>(Directory.EnumerateFiles(currPath));
foreach( string dir in theFiles){
    Console.WriteLine(dir);
}
Console.WriteLine("---------------");

Console.WriteLine("All directory contents:");
