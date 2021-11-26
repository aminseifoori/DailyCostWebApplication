using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.CustomHtmlHelpers
{
    public class AllowedCharcterLength : StringLengthAttribute
    {
        public AllowedCharcterLength() : base(10)
        {
        }
    }
}
