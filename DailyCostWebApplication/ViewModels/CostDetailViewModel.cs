using DailyCostWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.ViewModels
{
    public class CostDetailViewModel
    {
        public Cost CostData { get; set; }
        public string PageTitle { get; set; }
    }
}
