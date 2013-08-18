namespace WinrtErrLog
{
    public class ExceptionEntry
    {
        public ExceptionEntry(string EntryID, string Data)
        {
            entryId = EntryID;
            data = Data;
        }

        public string entryId { get; set; }
        public string data { get; set; }
    }
}
