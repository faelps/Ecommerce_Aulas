using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RafaelRoupasECalcados.Adm.ViewModel
{
    public class AdicionarOuEditarCategoriaViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150, ErrorMessage = "o nome da categoria, não pode ultrapassar o maximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "o nome da categoria deve conter no minimo {0} caracteres")]
        public string Nome { get;  set; }
        public string Imagem { get; set; }
    }
}
