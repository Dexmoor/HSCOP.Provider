using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSCOP.Provider.DataAccess.Entities
{
    [Table("ProviderComposition", Schema = "Provider")]
    public class ProviderComposition
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }
    }
}
