namespace Frank.MimeTypes;

public static class MimeTypeHelper
{
    private readonly static MimeTypeCollection MimeTypeCollection = new();

    public static MimeType GetMimeTypeFromFilename(string fileName) => MimeTypeCollection[Path.GetExtension(fileName)];
    public static MimeType GetMimeTypeFromExtension(string extension) => MimeTypeCollection[extension];
    
    public static bool TryGetMimeTypeFromFile(FileInfo file, out MimeType? mimeType)
    {
        var result = MimeTypeCollection.FirstOrDefault(m => m.Extension == file.Extension);
        if (result != null)
        {
            mimeType = result;
            return true;
        }
        {
            mimeType = null;
            return false;
        } 
    }
}