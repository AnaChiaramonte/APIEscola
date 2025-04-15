using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Matricula
    {
        public Guid MatriculaId { get; set; }

        [Required(ErrorMessage = "O Campo Data da Matricula é Obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "A Data Informada não é Válida")]
        public DateOnly DataMatricula { get; set; }

        public Guid? TurmaId { get; set; }
        public Turma? Turma { get; set; }

        public Guid? AlunoId { get; set; }
        public Aluno? Aluno { get; set; }

    }
}
