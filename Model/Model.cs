using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class FinancialBand
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public int ProcurementTypeID { get; set; }
        public List<ProcurementType> ProcurementType { get; set; }
        public bool Recurrent { get; set; }
    }

    public class ProcurementBand
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public int ProcurementTypeID { get; set; }
        public List<ProcurementType> ProcurementType { get; set; }
    }

    public class ProcurementType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public int? MaxDelegation { get; set; }
        public int ProcurementBandID { get; set; }
        public ProcurementBand ProcurementBand { get; set; }
    }

}
