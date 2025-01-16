using System; // para DateTime
using System.ComponentModel.DataAnnotations;
public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
