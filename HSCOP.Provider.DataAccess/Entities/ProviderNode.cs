using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSCOP.Provider.DataAccess.Entities
{
    [Table("ProviderNode", Schema = "Provider")]
    public class ProviderNode
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
