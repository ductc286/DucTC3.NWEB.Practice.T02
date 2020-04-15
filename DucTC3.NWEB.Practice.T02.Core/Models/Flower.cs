using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DucTC3.NWEB.Practice.T02.Core.Models
{
    /// <summary>
    /// Flower class
    /// </summary>
    public class Flower
    {
        [Key]
        public int FlowerId { get; set; }

        [Required(ErrorMessage = "Flower name is required.")]
        [StringLength(255)]
        [Display(Name = "Flower Name")]
        public string Name { get; set; }

        [Column("Description", TypeName = "ntext")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public string Color { get; set; }

        public string Image { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Store Date is required.")]
        [Display(Name = "Store Date")]
        public DateTime StoreDate { get; set; }

        [Required(ErrorMessage = "Store Inventory is required.")]
        [Display(Name = "Store Inventory")]
        public int StoreInventory { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
