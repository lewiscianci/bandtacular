using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Band
    {
        public string Name { get; set; }
        public int MaxDelegation { get; set; }

    }

    public class FinancialBand : Band
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int ID { get; set; }
    }

    public class ProcurementBand : Band
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int ID { get; set; }
    }

}
