using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.CustomHtmlHelpers
{
    public static class CustomHtmlHelpers
    {
        public static TagBuilder Image(this IHtmlHelper htmlHelper, string src, string alt, string klass)
        {
            TagBuilder tb = new("img");
            tb.Attributes.Add("src", src);
            tb.Attributes.Add("alt", alt);
            tb.Attributes.Add("class", klass);
            return tb;
        }
    }
}
