using LINQ_20260408;
using System.IO;

string path = @"C:\Users\School\Pictures\Screenshots";
ShowLargeFilesWithoutLinq(path);

static void ShowLargeFilesWithoutLinq(string path)
{
    //DirectoryInfo directory = new DirectoryInfo(path);
    //FileInfo[] files = directory.GetFiles();

    //for (int j = 0; j < files.Length; j++)
    //{
    //    long min = files[0].Length;
    //    for (int i = 0; i < files.Length - 1; i++)
    //    {
    //        if (min > files[i + 1].Length && !lengths.Contains(files[i + 1].Length))
    //        {
    //            min = files[i + 1].Length;
    //        }
    //        //Console.WriteLine(files[i].Length);

    //    }
    //    lengths[j] = min;
    //}

    //for (int a = 0; a < lengths.Length; a++)
    //{
    //    Console.WriteLine(lengths[a]);
    //}

    //foreach (FileInfo file in files)
    //{
    //    Array.Sort(files, new FileInfoComparer());
    //    Console.WriteLine($"{file.Name} : {file.Length}");
    //}


        //var query = from file in new DirectoryInfo(path).GetFiles()
        //            orderby file.Length descending
        //            select file;

        var query = new DirectoryInfo(path).GetFiles().OrderByDescending(f => f.Length).Take(5);

    //foreach (var file in query.Take(5))
    //{
    //    Console.WriteLine($"{file.Name,-50} : {file.Length,10:NO}");
    //}

    foreach (var file in query)
    {
        Console.WriteLine($"{file.Name,-50} : {file.Length,10:NO}");
    }

}


