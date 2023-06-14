using System.ComponentModel.DataAnnotations;

namespace GestaoPI.Models.Enums
{
    public enum PatenteSituacao
    {
        Anulada,
        Sigilo,
        [Display(Name = "Em Exame Técnico")]
        ExameTecnico,
        Arquivada,
        Indeferida,
        Concedida,
    }
}