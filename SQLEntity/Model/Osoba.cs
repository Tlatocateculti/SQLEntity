using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLEntity.Model
{
    [Table("Osoby")]
    public class Osoba
    {
        [Key]
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        public string? PESEL { get; set; }
    }
}
