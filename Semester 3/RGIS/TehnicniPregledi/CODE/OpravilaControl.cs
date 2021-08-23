using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class OpravilaControl {
	public Vozilo Vozilo;

	public Opravilo[] SeznamKritiènihOpravil(Vozilo vozilo) {
        return vozilo.Opravila.Where(t => t.JeOpraviloKritièno() == true).ToArray();
	}
	public string[] OpravilaIzpis(Opravilo[] seznamKritiènihOpravil) {
		throw new System.Exception("Not implemented");
	}
	public bool NajdiOpravila(Vozilo vozilo1) {
		throw new System.Exception("Not implemented");
	}
	public bool AliPotrjeno(bool brisi) {
		throw new System.Exception("Not implemented");
	}
	public bool NastaviOpravila(Opravilo opr) {
		throw new System.Exception("Not implemented");
	}
	public Opravilo[] OpravilaVozila(Vozilo vozilo) {
		throw new System.Exception("Not implemented");
	}


}
