public record CategoryResponse
(
    long Id,
    string Name,
    string Notes,
    bool IsActive,
    long CreatedBy,
    DateTime CreatedAt
);
