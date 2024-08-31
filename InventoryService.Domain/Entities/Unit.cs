namespace InventoryService.Domain.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommonService.Models;

[Table("Units", Schema = "inventory_data")]
public class Unit : BaseEntity<int>
{
    [Column("name")]
    public required Dictionary<string, string> Name { get; set; }

    [Column("conversion-unit-id")]
    public long? ConversionUnitId { get; set; }

    [Column("conversion-value")]
    public float ConversionValue { get; set; }

    [Column("is-base-unit")]
    public bool IsBaseUnit { get; set; }
}
