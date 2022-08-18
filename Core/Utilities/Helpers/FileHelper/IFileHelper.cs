using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helpers.FileHelper
{
    public interface IFileHelper
    {
        /*string Upload(IFormFile file, string root);*/ // Fotoğrafın nereye kaydedileceğini ve dosyayı veriyosun.
        void Delete(string filePath); // Dosya yolunu silme
        string Update(IFormFile file, string filePath, string root); // Dosyayı veriyosun dosya yolu dosyanın kaydedileceği yerde güncelleniyor.
        string Upload(IFormFile file, string root);
    
    }
}
