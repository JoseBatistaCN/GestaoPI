using System.ComponentModel.DataAnnotations;

namespace GestaoPI.Models.Enums
{
    public enum PatenteSituacao
    {
        [Display(Name = "Em Análise")]
        EmAnalise,
        Anulada,
        Sigilo,
        [Display(Name = "Em Exame Técnico")]
        ExameTécnico,
        Arquivada,
        Indeferida,
        Concedida,
    }

}