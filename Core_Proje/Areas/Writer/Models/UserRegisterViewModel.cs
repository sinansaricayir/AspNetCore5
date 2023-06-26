using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Giriniz!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz!")]
        [Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Adresi Giriniz!")]
        public string Mail { get; set; }
    }
}
