using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace praktyki.Models
{
    public class Praktyki
    {
        public int Id { get; set; }
        [MaxLength(256)]
        public string Nazwa { get; set; }
        public int LiczbaMiejc { get; set; }
        [DataType(DataType.MultilineText)]
        public string Opis { get; set; }
        public string Tagi { get; set; }
        [DataType(DataType.MultilineText)]
        public string Wymagania { get; set; }
        public string Kontakt { get; set; }
    }
}