using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id {get; set;}
        [Required(ErrorMessage ="Ad alanı boş bırakılamaz.")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Telefon alanı zorunlu.")]
        public string? Phone { get; set; }
        [Required(ErrorMessage ="Email alanı boş bırakılamaz.")]
        [EmailAddress(ErrorMessage ="Hatalı Email.")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Katılım durumunuzu belirtiniz.")]
        public bool? WillAttend { get; set; } 
    }
}
