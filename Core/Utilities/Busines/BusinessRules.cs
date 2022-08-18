using Core.Entities.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Busines
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)//params verdiğim zaman Run'a istediğin kadar IResult verebilirin
        {
            foreach (var logic in logics)
            {
                if (!logic.Success) //logic'in succes durumu başarısız ise business' iletiyor.
                {
                    return logic; //Mevcut hata varsa onu döndürüyor.
                }
            }
            return null; //Tüm kurallarım başarılı ise null döner.
        }
            
    }
}
