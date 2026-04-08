using System.Diagnostics.CodeAnalysis;

namespace LINQ_20260408;

public class FileInfoComparer :IComparer<FileInfo>
{
    public int Compare([AllowNull] FileInfo x, [AllowNull]  FileInfo y)
    {
        return y.Length.CompareTo(x.Length);
    }
}
