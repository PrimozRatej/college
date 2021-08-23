using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Opravilo {
	private string opisOpravila;
    private DateTime datumOpravila;
    private DateTime kritièniDatum;


    public string OpisOpravila {
		get {
			return opisOpravila;
		}
		set {
			opisOpravila = value;
		}
	}
	
	public DateTime DatumOpravila {
		get {
			return datumOpravila;
		}
		set {
			datumOpravila = value;
		}
	}
	
	public DateTime KritièniDatum {
		get {
			return kritièniDatum;
		}
		set {
			kritièniDatum = value;
		}
	}

	public bool JeOpraviloKritièno() {
        if (kritièniDatum <= DateTime.Today && datumOpravila>=DateTime.Today) return true;
        else return false;
	}
	public string Izpis() {
        return "Kritièni datum: " + kritièniDatum + "  Datum za opravilo: " + datumOpravila + "  Opis opravila: " + opisOpravila;
	}
	public bool BrisiOpravila() {
        WindowsFormsApplication1.BAZA.seznamOpravil.Remove(this);
        if (WindowsFormsApplication1.BAZA.seznamOpravil.Contains(this)) return false;
        else return true;
	}
	public bool SetOpravila() {
        WindowsFormsApplication1.BAZA.seznamOpravil.Add(this);
        if (WindowsFormsApplication1.BAZA.seznamOpravil.Contains(this)) return true;
        else return false;

	}
    public Opravilo(string opisOpravila, DateTime datumOpravila, DateTime kritièniDatum)
    {
        this.opisOpravila = opisOpravila;
        this.datumOpravila = datumOpravila;
        this.kritièniDatum = kritièniDatum;
    }


}
