namespace InventoryService.Contracts.Units;

using System.ComponentModel.DataAnnotations;

public record UnitDto
(
    [Required(ErrorMessage = "Name is required.")]
    Dictionary<string, string> Name,

    long? ConversionUnitId,

    [Required(ErrorMessage = "Conversion value is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Conversion value must be greater than zero.")]
    float ConversionValue,

    bool IsBaseUnit
);