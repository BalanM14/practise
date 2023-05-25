using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BefTry.Model
{
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int GroupId { get; set; }

        public string? GroupName { get; set; }

        [ForeignKey("User")]
        public int userid { get; set; }
        public virtual User? User { get; set; }


    }
}
