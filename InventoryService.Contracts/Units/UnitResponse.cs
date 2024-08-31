namespace InventoryService.Contracts.Units;

public record UnitResponse
(
    long Id,
    Dictionary<string, string> Name,
    long? ConversionUnitId,
    float ConversionValue,
    bool IsBaseUnit,
    long CreatedBy,
    DateTime CreatedAt
);