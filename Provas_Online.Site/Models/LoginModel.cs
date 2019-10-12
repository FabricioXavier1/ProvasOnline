using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Provas_Online.Site.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Campo e-mail obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo senha obrigatório")]
        public string Senha { get; set; }
    }
}
