using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;


namespace GestaoPI.Services
{
    public class RPIDownloader
    {
        private string url = "http://revistas.inpi.gov.br/txt/";
        private string path = @"Revistas/";

        public RPIDownloader(string tipo, string numeroRevista)
        {
            this.url += tipo + numeroRevista + ".zip";

        }

        public async Task Download()
        {
            var httpClient = new HttpClient();
            using (var stream = await httpClient.GetStreamAsync(url))
            {
                using (var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    await stream.CopyToAsync(fileStream);
                }
            }
        }

    }
}