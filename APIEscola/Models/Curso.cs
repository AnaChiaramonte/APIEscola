using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Curso
    {
        public Guid CursoId { get; set; }

        [Required(ErrorMessage = "O Campo Sigla é Obrigatório")]
        [MaxLength(10, ErrorMessage = "O Nome deve ter no máximo 10 caracteres")]//Máximo 10
        public string Sigla { get; set; }

        [Required(ErrorMessage = "O Campo Descrição é Obrigatório")]
        [MaxLength(255, ErrorMessage = "O Nome deve ter no máximo 255 caracteres")]
        public string? Descricao { get; set; }


    }
}
