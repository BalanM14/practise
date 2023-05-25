using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BefTry.Model
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int CommentId { get; set; }

        [ForeignKey("User")]
        public int userid { get; set; }
        public virtual User? User { get; set; }

        [ForeignKey("Post")]
        public int postid { get; set; }
        public virtual Post? Post { get; set; }
        public string? Comments { get; set; }
    }
}
