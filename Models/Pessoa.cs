using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Comeia.Models
{
    [Table("pessoa")]
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome completo")]
        public string Full_name { get; set; }
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        public DateTime Birth_date { get; set; }
        [Range(0,3)]
        [Display(Name = "Genero")]
        public int Gender { get; set; }
    }
}
