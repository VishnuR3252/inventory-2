using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommonService.Models;
namespace InventoryService.Domain.Entities;


[Table("item_category", Schema = "inventory_data")]
public class Category : BaseEntity<int>
{
    [Column("name")]
    public required string Name { get; set; }

    [Column("notes")]
    [StringLength(100, ErrorMessage = "Notes must be 200 characters or fewer.")]
    public required string Notes { get; set; }

    [Column("is_active")]
    public bool IsActive { get; set; }

}