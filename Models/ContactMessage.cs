namespace portfolio_website.Models;
using System.ComponentModel.DataAnnotations;

public class ContactMessage
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    [MaxLength(200)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid email.")]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Message is required.")]
    [MaxLength(5000)]
    public string Message { get; set; } = string.Empty;

    public DateTime SentAt { get; set; } = DateTime.UtcNow;
}