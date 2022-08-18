using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelperManager : IFileHelper
    {
        public string Upload(IFormFile file, string root) // verdiğin dosya istenilen yere yükleniyor.
        {
            if (file.Length > 0) //Dosya boyutu 0'dan büyük olmalı ki resim olsun.
            {
                if (!Directory.Exists(root)) // yüklenilecek yer var mı ? Yoksa yarat.
                {
                    Directory.CreateDirectory(root);
                }
            }

            string extension = Path.GetExtension(file.FileName); // Dosyanın uzantısını alıyor.
            string guid = Guid.NewGuid().ToString(); //Dosyanın ismini rasgele isim yapıyor.
            string filePath = guid + extension; // Resmin bütününü oluşturuyor.

            using (FileStream fileStream = File.Create(root + filePath))
            {
                file.CopyTo(fileStream);
                fileStream.Flush(); // Ara bellekten siler.
                return filePath;
            }            
        }
        public void Delete(string filePath) //Buradaki strin filePath,'CarİmageManager'den gelen dosyamın kaydedildiği adrse ve adı
        {
            if (File.Exists(filePath)) 
            {
                File.Delete(filePath);// Verilen dosya yolu varsa siler
            }
        }

        public string Update(IFormFile formFile, string filePath, string root)
        {
            Delete(filePath); //Dosya yolunu siler yenisini yükler.
            return Upload(formFile, root);
        }

      
    }
}
