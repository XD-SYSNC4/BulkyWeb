using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
       
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Range(1, 30, ErrorMessage="Display order must be between 1 and 30")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
