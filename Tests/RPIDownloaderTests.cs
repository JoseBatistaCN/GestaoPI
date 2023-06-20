using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using GestaoPI.Services;

namespace GestaoPI.Tests
{
    public class RPIDownloaderTests
    {
        [Fact]
        public async void RPIDownloader_DeveBaixarArquivo()
        {
            // Given
            string numeroRevista = "2737";
            string tipo = "P";
        
            // When
            var downloader = new RPIDownloader(tipo, numeroRevista);
        
            // Then

            await downloader.Download();
        }
    }
}