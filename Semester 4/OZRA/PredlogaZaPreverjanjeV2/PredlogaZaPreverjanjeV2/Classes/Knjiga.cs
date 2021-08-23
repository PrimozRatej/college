using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PredlogaZaPreverjanjeV2.Classes
{
    [DataContract]
    public class Knjiga
    {
        [DataMember(EmitDefaultValue = false)]
        public int Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Naslov { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Avtor { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int StStrani { get; set; }
    }
}
