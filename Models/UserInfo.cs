using System.ComponentModel.DataAnnotations;

namespace meetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İsim Alanı Zorunludur!")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Telefon Numarası Zorunlu!")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "E-Posta Alanı Zorunlu!")]
        [EmailAddress(ErrorMessage = "Lütfen Geçerli bir E-Posta Adresi Giriniz!")]
        public string? Email { get; set; }
        [Required]
        public bool WillAttend { get; set; }

    }
}