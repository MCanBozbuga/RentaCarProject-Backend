using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; } //girş yapan kullanıcıya verilen token
        public DateTime Expiration { get; set; } // kullanıcının token süresinin gerçiliği
    }
}
