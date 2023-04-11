using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace GestaoPI.Models;

public partial class Processo
{
    private string _codigo = null!;

    [Required]
    public string Codigo
    {
        get => _codigo;
        set
        {
            string regexCodigo = @"^[A-Z]{2}\s[0-9]{2}\s[0-9]{4}\s[0-9]{6}-[0-9]$";
            if (Regex.IsMatch(value, regexCodigo))
            {
                _codigo = value;
            }
            else
            {

            }
        }
    }

    public string? Titulo { get; set; }

    public string? Resumo { get; set; }

    public DateOnly? Deposito { get; set; }

    public DateOnly? Exame { get; set; }

    public DateOnly? DominioPublico { get; set; }

    public string? Anotacao { get; set; }

    public string? CodigoNotificacao { get; set; }
}
