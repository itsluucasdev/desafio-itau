using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Models
{
    public class Taxa
    {
        [Key]
        public int TaxaId { get; set; }

        [MaxLength(12, ErrorMessage = "Este campo deve ter entre 6 e 12 caracteres")]
        [MinLength(6, ErrorMessage = "Este campo deve ter entre 6 e 12 caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Segmento { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "Taxa deve ser maior que zero")]
        public decimal TaxaSegmento { get; set; }
    }
}
