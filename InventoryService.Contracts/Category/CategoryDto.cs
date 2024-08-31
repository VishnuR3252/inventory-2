using System.ComponentModel.DataAnnotations;

public record CategoryDto
(
    [Required(ErrorMessage = "Name is required.")]
    string Name,

    string Notes,

    bool IsActive
);