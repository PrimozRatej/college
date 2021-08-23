using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class EvidencaControl {
	public Vozilo Vozilo;

    public EvidencaControl(Vozilo voz) // TODO dodaj v graf
    {
        this.Vozilo = voz;
    }
	public bool Preverivozilo() {
		throw new System.Exception("Not implemented");
	}
	public bool PreveriVozilo(int serijska) {
		throw new System.Exception("Not implemented");
	}
	public bool AliPotrjeno(bool briši) {
		throw new System.Exception("Not implemented");
	}
	public bool NjadiVozilo(int serijska) {
		throw new System.Exception("Not implemented");
	}

    public void IzpisEvidence()
    {
        Evidenca evidenca = new Evidenca(Vozilo.Opravila.ToList());
        evidenca.IzpisEvidence();
    }


}
