namespace Gaz_vod_Praktika.Data
{
    public class Message
    {
        public Message(string text, string fileName)
        {
            Text = text;
            FileName = fileName;
        }

        public string Text { get; set; }
        public string FileName { get; set; }
    }
}
