using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bandtastic.ViewModels
{
    public class Index
    {
        public Model.ProcurementType ProcumenType { get; set; }
        public Model.FinancialBand FinancialBand { get; set; }
        public Model.ProcurementBand ProcurementBand { get; set; }
    }
}