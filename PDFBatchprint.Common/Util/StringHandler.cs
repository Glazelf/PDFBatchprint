namespace PDFBatchprint.Common
{
    public class StringHandler
    {
        public static string FilePathToName(string FilePath)
        {
            string[] FilePathSplit = FilePath.Split("\\");
            string FileName = FilePathSplit[^1];
            return FileName;
        }

        public static string ReplaceLastOccurrence(string Source, string Find, string Replace)
        {
            int place = Source.LastIndexOf(Find);

            if (place == -1)
                return Source;

            string result = Source.Remove(place, Find.Length).Insert(place, Replace);
            return result;
        }
    }
}
