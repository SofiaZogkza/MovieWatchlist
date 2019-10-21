using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization;

namespace Types
{
    [DataContract]
    public class Request
    {
        [DataMember(Name = "api_key")]
        public string ApiKey { get; set; }
        [BindProperty(SupportsGet = true)]
        [DataMember(Name = "query")]
        public string Title { get; set; }
    }
}
