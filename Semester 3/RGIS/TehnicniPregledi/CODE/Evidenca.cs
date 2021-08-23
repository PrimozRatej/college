using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public class Evidenca {
    List<Opravilo> seznamOpravil;

  
    public Evidenca(List<Opravilo> seznam)
    {
        this.seznamOpravil = seznam;
    }
	public void IzpisEvidence() {
        string nizEvidenca = "";
        foreach (var opravilo in seznamOpravil)
        {
            nizEvidenca = nizEvidenca+" "+opravilo.Izpis() + "\n";
        }

        MessageBox.Show(nizEvidenca);
	}
	public Evidenca Ustvari(Opravilo[] opravila) {
		throw new System.Exception("Not implemented");
	}

}
