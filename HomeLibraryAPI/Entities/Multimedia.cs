namespace HomeLibraryAPI.Entities
{
    public class Multimedia : LibraryElement
    {
        public int RecordLabelId { get; set; }
        public virtual RecordLabel RecordLabel { get; set; }
        public TimeSpan RecordDuration { get; set; }
        public List<string> 
    }
}
