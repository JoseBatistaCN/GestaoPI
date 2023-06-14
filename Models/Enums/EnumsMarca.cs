using System.ComponentModel.DataAnnotations;

namespace GestaoPI.Models.Enums
{
    public enum MarcaSituacao
    {
        Publicado,
        Arquivado,
        Indeferido,
        Concedido,

        [Display(Name = "Aguardando Sobrestamento")]
        AguardandoSobrestamento,
        Extinto
    }

    public enum MarcaApresentacao
    {
        Nominativa,
        Figurativa,
        Mista,
        Tridimensional,
    }
}