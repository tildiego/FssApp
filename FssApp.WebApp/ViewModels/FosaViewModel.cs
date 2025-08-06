using System.ComponentModel.DataAnnotations;

namespace FssApp.WebApp.ViewModels
{
    public class FosaViewModel
    {
        public int FosaId { get; set; }

        [Required]
        [StringLength(150)]
        public string FosaNom { get; set; } = string.Empty;
    }
}
