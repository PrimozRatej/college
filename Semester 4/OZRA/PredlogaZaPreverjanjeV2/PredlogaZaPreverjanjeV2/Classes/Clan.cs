using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PredlogaZaPreverjanjeV2.Classes
{
    [DataContract]
    public class Clan
    {
        [DataMember(EmitDefaultValue = false)]
        public int Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Ime { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Priimek { get; set; }
    }
}
