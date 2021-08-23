
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public class VoziloControl {
    private Vozilo vozilo = new Vozilo(); 

	public Vozilo[] GetSeznamVozil() {
        return vozilo.GetAll().ToArray();
	}
	public Vozilo[] SortirajSeznamVozil() {
        return WindowsFormsApplication1.BAZA.seznamVozil.OrderBy(t => t.ID).ToArray();
	}
	public string[] VoziloIzpis(Vozilo[] vozilo) {
        List<string> vozila = new List<string>();
        foreach (var voz in vozilo)
        {
           vozila.Add(voz.Izpis());
        }
        return vozila.ToArray();
	}
	public Vozilo[] SeznamKritiènihVozil(Vozilo[] seznam) {
		return seznam.Where(t=>t.VoziloKritièno() == true).ToArray();
	}
	public string IzpisVozila(Vozilo vozilo) {
		throw new System.Exception("Not implemented");
	}
	public bool AliSoPodatkiPravilni(int iD, string znamka, string model, int letnik, double porabaLitri, int serijska, DateTime datumprveregistracije,double masa, string tip) {
        if (GetSeznamVozil().Select(t => t.ID).Contains(iD)) return false;
        if (letnik < 1800 || letnik > DateTime.Today.Year) return false;
        return true;
	}
	public void NastaviVozilo(string znamka, string model, int letnik, string imeLastnika, string priimekLastnika) {
		throw new System.Exception("Not implemented");
	}
	public Vozilo VoziloPridobi(int voziloID) {
		throw new System.Exception("Not implemented");
	}
	public Vozilo[] VozilaPrekoRoka() {
		throw new System.Exception("Not implemented");
	}


}
