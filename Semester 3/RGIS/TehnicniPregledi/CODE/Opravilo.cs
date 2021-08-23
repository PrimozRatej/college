using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Opravilo {
	private string opisOpravila;
    private DateTime datumOpravila;
    private DateTime kriti�niDatum;


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
	
	public DateTime Kriti�niDatum {
		get {
			return kriti�niDatum;
		}
		set {
			kriti�niDatum = value;
		}
	}

	public bool JeOpraviloKriti�no() {
        if (kriti�niDatum <= DateTime.Today && datumOpravila>=DateTime.Today) return true;
        else return false;
	}
	public string Izpis() {
        return "Kriti�ni datum: " + kriti�niDatum + "  Datum za opravilo: " + datumOpravila + "  Opis opravila: " + opisOpravila;
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
    public Opravilo(string opisOpravila, DateTime datumOpravila, DateTime kriti�niDatum)
    {
        this.opisOpravila = opisOpravila;
        this.datumOpravila = datumOpravila;
        this.kriti�niDatum = kriti�niDatum;
    }


}
