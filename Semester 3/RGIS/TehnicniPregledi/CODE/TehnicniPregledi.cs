using System;
using System.Data;
using System.Linq;
public class TehnicniPregledi {

	private int iD;
	private Vozilo vozilo;
	public string OpisPregleda;
	public DateTime DatumPregleda;
	private string izvajalec;
	private double cena;

    public TehnicniPregledi(int ID,Vozilo vozilo, string opisPregleda, DateTime datumPregleda, string izvajalec, double cena)
    {
        this.iD = ID;
        this.vozilo = vozilo;
        this.OpisPregleda = opisPregleda;
        this.DatumPregleda = datumPregleda;
        this.izvajalec = izvajalec;
        this.cena = cena;
    }
    public TehnicniPregledi[] GetTehniènePreglede(Vozilo vozilo1) {
        return WindowsFormsApplication1.BAZA.seznamtehničnihPregledov.Where(t => t.vozilo == vozilo1).ToArray();
	}
	public bool SetTehniènePreglede(TehnicniPregledi tehPre) {
		throw new System.Exception("Not implemented");
	}
	public TehnicniPregledi[] PridobiTehniènePreglede(Vozilo vozilo) {
		throw new System.Exception("Not implemented");
	}
	public TehnicniPregledi() {
		
	}
	public string Izpis() {
        return "ID: " + iD + "vozilo ID: " + vozilo.ID + " " + OpisPregleda + " Datum pregleda: " + DatumPregleda + " Izvajalec:" + izvajalec + " Cena:" + cena;
	}

}
