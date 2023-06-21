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
    
    public async Task<string> DownloadRPI()
    {
        using (HttpClient client = new HttpClient())
        {
            using (HttpResponseMessage response = await client.GetAsync(_url))
            {
                using (HttpContent content = response.Content)
                {
                    await content.ReadAsStreamAsync();
                    using (var fileStream = File.Create(_fileName))
                    {
                        (await content.ReadAsStreamAsync()).CopyTo(fileStream);
                        return "Arquivo baixado com sucesso!";
                    }
                }
            }
        }
    }
    
    
    }
        
}