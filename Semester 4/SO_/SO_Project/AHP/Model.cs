using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHP
{
    [Serializable]
    public class Model
    {
        public List<string> NaziviAlternativ { get; set; }
        public Vozlisce Koren { get; set; }
    }
}
