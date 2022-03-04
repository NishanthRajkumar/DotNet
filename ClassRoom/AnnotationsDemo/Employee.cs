using System.ComponentModel.DataAnnotations;

namespace AnnotationsDemo;

internal class Employee
{
    [Required(ErrorMessage = "Employee {0} is required")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Name should have minimum of 3 charaters and maximum 100 characters")]
    [DataType(DataType.Text)]
    public string Name { get; set; } //234567654
    [Range(18, 100, ErrorMessage = "Age should be above 18 and less than 100")]
    // [Range(18, 100, ErrorMessage = "Age should be above 18")]
    public int Age { get; set; }
    [DataType(DataType.PhoneNumber)] //91  46
    [Phone]
    public string PhoneNumber { get; set; }
    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string Email { get; set; }
}
