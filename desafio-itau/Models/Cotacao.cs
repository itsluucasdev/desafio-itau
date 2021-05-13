using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Models
{
    public class Cotacao
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(3, ErrorMessage = "Este campo deve conter 3 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter 3 caracteres")]
        public string MoedaEstrangeira { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que zero")]
        public decimal QtdeValorEstrangeiro { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Segmento inválido")]
        public int TaxaId { get; set; }

        public decimal ValorEmReais { get; set; }

        public Taxa Taxa { get; set; }
    }
}
