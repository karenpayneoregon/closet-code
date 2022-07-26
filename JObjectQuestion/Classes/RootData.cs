using System.Text.Json.Serialization;

namespace JObjectQuestion.Classes
{

    public class RootData
    {
        public string _index { get; set; }
        public string _id { get; set; }
        public _Source _source { get; set; }
        public Highlight highlight { get; set; }
    }

    public class _Source
    {
        public string path { get; set; }
        public Attachment attachment { get; set; }
    }

    public class Attachment
    {
        
        public string content_type { get; set; }
        public string format { get; set; }
    }

    public class Highlight
    {
        [JsonPropertyName("attachment.content")]
        public string[] attachmentcontent { get; set; }
    }

}
