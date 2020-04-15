namespace DucTC3.NWEB.Practice.T02.Core.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Category class
    /// </summary>
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        
        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(100)]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Order is required.")]
        public int Order { get; set; } = 1;


        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public virtual IList<Flower> Flower { get; set; }
    }
}
