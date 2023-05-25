using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace BefTry.Model
{
    public class User
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int userid { get; set; }
        public string name { get; set; } = string.Empty;
        public string? email { get; set; }
        public string? password { get; set; }
        public string? phone { get; set; }

        public ICollection<Post>? posts { get; set; }

        public ICollection<Comment>? comments { get; set; }

        public ICollection<Group>? groups { get; set; }

    }
}
