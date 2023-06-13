using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class TestFormViewModel
    {
        [Required]
        public string Number { get; set; }
    }
}
