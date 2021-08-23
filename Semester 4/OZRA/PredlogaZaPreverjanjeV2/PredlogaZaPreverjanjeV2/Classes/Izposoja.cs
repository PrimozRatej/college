using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PredlogaZaPreverjanjeV2.Classes
{
    [DataContract]
    public class Izposoja
    {
        [DataMember(EmitDefaultValue = false)]
        public int? Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DateTime DatumIzposoje { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DateTime? DatumVrnitve { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int DolzinaIzposoje { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int IdKnjige { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int IdClana { get; set; }
    }
}
