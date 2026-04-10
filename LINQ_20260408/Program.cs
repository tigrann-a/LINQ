using LINQ_20260408;
using System.IO;

string path = @"C:\Users\School\Pictures\Screenshots";
ShowLargeFilesWithoutLinq(path);

static void ShowLargeFilesWithoutLinq(string path)
{
    DirectoryInfo directory = new DirectoryInfo(path);
    FileInfo[] files = directory.GetFiles();

    for(int i = 0; i < files.Length - 1; i++)
    {
        for (int j = 0; j < files.Length - i - 1; j++)
        {
            if (files[j].Length < files[j + 1].Length)
            {
                FileInfo temp = files[j];
                files[j] = files[j + 1];
                files[j + 1] = temp;
            }
        }
    }

    int k = 1;
    foreach(var file in files)
    {
        if(k <= 5)
            Console.WriteLine($"{file.Length}");
        k++;
    }
        

    //var query = from file in new DirectoryInfo(path).GetFiles()
    //            orderby file.Length descending
    //            select file;

    //var query = new DirectoryInfo(path).GetFiles().OrderByDescending(f => f.Length).Take(5);

    //foreach (var file in query.Take(5))
    //{
    //    Console.WriteLine($"{file.Name,-50} : {file.Length,10:NO}");
    //}

    //foreach (var file in query)
    //{
    //    Console.WriteLine($"{file.Name,-50} : {file.Length,10:NO}");
    //}
}

//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//var eventNumbers = numbers.Where(n => n % 2 == 0);

//foreach (var number in eventNumbers)
//{
//    Console.WriteLine(number);
//}

//Console.WriteLine();

//var first = numbers.First();

//Console.WriteLine($"The first number is: {first}");

//Console.WriteLine();

//var hasBigNumber = numbers.Any(n => n > 100);

//Console.WriteLine($"Does numbers array have big numbers: {hasBigNumber}");

//Console.WriteLine();

//var total = numbers.Sum();

//Console.WriteLine($"The sum of numbers is: {total}");

