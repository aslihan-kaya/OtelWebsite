using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OtelWebsite.Models
{
    public class User
    {
        [Required]
        public string KullaniciAdi { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
    }
}