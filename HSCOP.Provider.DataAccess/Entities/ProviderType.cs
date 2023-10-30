using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSCOP.Provider.DataAccess.Entities
{
    [Table("ProviderType", Schema = "Provider")]
    public class ProviderType
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime UpdatedDate { get; set; }

        [Required]
        public int CreatedUserId { get; set; }

        [Required]
        public int UpdatedUserId { get; set; }
    }
}
