using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Types
{
    [DataContract]
    public class Movie
    {
        [DataMember(Name = "popularity"), NotMapped]
        public long Popularity { get; set; }

        [DataMember(Name = "vote_count"), NotMapped]
        public int VoteCount { get; set; }

        [DataMember(Name = "video"), NotMapped]
        public bool Video { get; set; }
        
        [DataMember(Name = "poster_path"), NotMapped]
        public string poster_path { get; set; 
        }
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "adult"), NotMapped]
        public bool Adult { get; set; }

        [DataMember(Name = "backdrop_path"), NotMapped]
        public string BackdropPath { get; set; }

        [DataMember(Name = "original_language"), NotMapped]
        public string OriginalLanguage { get; set; }

        [DataMember(Name = "original_title"), NotMapped]
        public string OriginalTitle { get; set; }

        [DataMember(Name = "genre_ids"), NotMapped]
        public int[] GenreIds { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "vote_average"), NotMapped]
        public long VoteAverage { get; set; }

        [DataMember(Name = "overview"), NotMapped]
        public string Overview { get; set; }

        [DataMember(Name = "release_date"), NotMapped]
        public string ReleaseDate { get; set; }
    }
}
