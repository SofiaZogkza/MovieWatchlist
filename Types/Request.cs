using System.Runtime.Serialization;

namespace Types
{
    [DataContract]
    public class Request
    {
        [DataMember(Name = "api_key")]
        public string ApiKey { get; set; }
        [DataMember(Name = "query")]
        public string Title { get; set; }
    }
}
