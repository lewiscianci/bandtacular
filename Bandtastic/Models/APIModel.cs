using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bandtastic.Models
{
    public class APIModel
    {
        public class Parameters
        {

            public int Type { get; set; }
            public int TotalAmount { get; set; }
            public int Risk { get; set; }
            public int ExpenditureType { get; set; }

        }

        public class Response
        {
            public string FinancialTypeBandRequired { get; set; }
            public string Explanation { get; set; }
        }
    }
}