namespace Frank.MimeTypes;

public static class MimeTypeHelper
{
    private readonly static MimeTypeCollection MimeTypeCollection = new();

    public static MimeType GetMimeTypeFromFilename(string fileName) => MimeTypeCollection[Path.GetExtension(fileName)];
    public static MimeType GetMimeTypeFromExtension(string extension) => MimeTypeCollection[extension];
    
    public static MimeType? GetMimeTypeFromMediaType(string mediaType) => MimeTypeCollection.FirstOrDefault(x => x.MediaType == mediaType);
    
    public static MimeType? GetMimeTypeFromName(string name) => MimeTypeCollection.FirstOrDefault(x => x.Name == name);
}