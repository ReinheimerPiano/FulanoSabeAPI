using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FulanoSabeAPI.Models;
using FulanoSabeAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FulanoSabeAPI.Controllers
{
    public class LojaController:ApiController<Loja>
    {
        public LojaController(CrudService<Loja> servico) : base(servico)
        {
        }

        public async Task<IActionResult> ImagensLoja(ICollection<IFormFile> imagens, int Id)
        {
            var uploads = Path.Combine($@"uploads\{Id}");
            if (!Directory.Exists(uploads))
            {
                Directory.CreateDirectory(uploads);
            }
            foreach (var formFile in imagens)
            {
                var filePath = $@"{uploads}\{formFile.FileName}";
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.OpenOrCreate))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }
            return Ok(new {Total = imagens.Count, SavedAt = uploads });
        }
    }
}