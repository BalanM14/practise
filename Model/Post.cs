using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BefTry.Model
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int? postid { get; set; }

        [ForeignKey("User")]
        public int? userid { get; set; }
        public virtual User? User { get; set; }
        public string? content { get; set; }

        [Column(TypeName ="Date"),DisplayFormat(DataFormatString ="{dd/MM/yyyy}")]

        public DateTime CreatedDate { get; set; }

        //public DateTime? created { get; set; } = default(DateTime?);

        public ICollection<Comment>? Comments { get; set; }

    }
}
