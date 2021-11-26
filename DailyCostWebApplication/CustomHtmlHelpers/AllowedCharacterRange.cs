using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.CustomHtmlHelpers
{
    public class AllowedCharacterRange : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string str = Convert.ToString(value);
            return str.Length >= 5 && str.Length <= 10;
        }
    }
}
