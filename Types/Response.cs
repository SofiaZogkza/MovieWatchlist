using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Types
{
    [DataContract]
    public class Response
    {
        [DataMember(Name = "page")]
        public int Page { get; set; }
        [DataMember(Name = "total_results")]
        public int TotalResults { get; set; }
        [DataMember(Name = "total_pages")]
        public int TotalPages { get; set; }
        [DataMember(Name = "results")]
        public Movie[] Movie { get; set; }
    }
}
