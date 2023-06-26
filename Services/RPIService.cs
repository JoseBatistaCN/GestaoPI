using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;


namespace GestaoPI.Services
{
    public class RPI
    {
        private string _url = "http://revistas.inpi.gov.br/txt/";
        private string _titular;
        private string _fileName;
        
        public RPI(string tipoProcesso, string numeroRevista, string titular)
        {
            this._fileName = tipoProcesso + numeroRevista + ".zip";
            this._url += _fileName;
            this._titular = titular;
        }
    

    
    }
    
        
}