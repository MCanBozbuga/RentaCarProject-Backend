using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    /// <summary>
    /// Web API de appsettings kısımlarında token options sekmem var. orada ki değerlerle buradaki değerleri eşlemem gerekecek. daha nesnel çalışmak için Bir JWT üretmenin çeşitli standartları var bizim bunları veriyor olmamız gerekiyor.Appsetting içerisinde ki verilere JWT oluştururken ihtiyacım var.bende orada ki değerleri bu nesnemiz ile mapp edip 'CreateToken' yaparken kullanacağız.
    /// </summary>
    public class TokenOptions
    {
      
        public string Audience { get; set; } //Bizim token'ımızın kullanıcı kitlesi
        public string Issuer { get; set; } // imzalayanı
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}
