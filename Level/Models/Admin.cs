using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Level.Models
{
    public class Admin
    {
        public int ID { get; set; }      

        [StringLength(50), Column(TypeName = "varchar(50)"), Display(Name = "Yönetici Adı Soyadı")]
        public string NameSurname { get; set; }

        [StringLength(50), Column(TypeName = "varchar(20)"), Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [StringLength(32), Column(TypeName = "varchar(32)"), Display(Name = "Şifre")]
        public string Password { get; set; }

    }
}
