using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Vozilo {
	private int iD;
    private string znamka;
    private string model;
    private int letnik;
    private double poraba_litri;
    private int serijskaStevilka;
    private DateTime date_PrvaRegistracija;
    private double masa;
    private string tip;
    private Opravilo[] opravila;

    #region Prop
    public int ID {
		get {
			return iD;
		}
		set {
			iD = value;
		}
	}
	
	public string Znamka {
		get {
			return znamka;
		}
		set {
			znamka = value;
		}
	}
	
	public string Model {
		get {
			return model;
		}
		set {
			model = value;
		}
	}
	
	public int Letnik {
		get {
			return letnik;
		}
		set {
			letnik = value;
		}
	}
	
	public double Poraba_litri {
		get {
			return poraba_litri;
		}
		set {
			poraba_litri = value;
		}
	}
	
	public int SerijskaStevilka {
		get {
			return serijskaStevilka;
		}
		set {
			serijskaStevilka = value;
		}
	}
	
	public DateTime Date_PrvaRegistracija {
		get {
			return date_PrvaRegistracija;
		}
		set {
			date_PrvaRegistracija = value;
		}
	}
	
	public double Masa {
		get {
			return masa;
		}
		set {
			masa = value;
		}
	}
	
	public string Tip {
		get {
			return tip;
		}
		set {
			tip = value;
		}
	}
	
	public Opravilo[] Opravila {
		get {
			return opravila;
		}
		set {
			opravila = value;
		}
	}
    #endregion

    public Vozilo() {
		
	}
    public Vozilo(int iD, string znamka, string model, int letnik, double porabaLitri, int serijskaStevilka, DateTime dateRegistracija, double masa, string tipVozila, Opravilo[] opravila)
    {
        this.iD = iD;
        this.znamka = znamka;
        this.model = model;
        this.letnik = letnik;
        this.poraba_litri = porabaLitri;
        this.serijskaStevilka = serijskaStevilka;
        this.date_PrvaRegistracija = dateRegistracija;
        this.masa = masa;
        this.tip = tipVozila;
        this.opravila = opravila;
    }

    
	public bool VoziloShrani() {
        WindowsFormsApplication1.BAZA.seznamVozil.Add(this);
        if (WindowsFormsApplication1.BAZA.seznamVozil.Contains(this)) return true;
        else return false;
	}
	public Vozilo GetVozilo(int id) {
        if (AliVoziloObstaja(id) == false) throw new System.Exception("Hotel si dostoptai do vozila z ID" + id + " vendar ta ne obstaja");
        return WindowsFormsApplication1.BAZA.seznamVozil.Find(t => t.iD == id);
	}
	public bool BrišiVozilo(Vozilo vozilo) {
        if (AliVoziloObstaja(vozilo.iD) == false) throw new System.Exception("Hotel si brisati vozilo z ID" + vozilo.iD + " vendar ta ne obstaja");
        WindowsFormsApplication1.BAZA.seznamVozil.Remove(vozilo);
        if (WindowsFormsApplication1.BAZA.seznamVozil.Contains(vozilo)) return false;
        else return true;

    }
	public bool AliVoziloObstaja(int voziloID) {
        return WindowsFormsApplication1.BAZA.seznamVozil.Exists(t => t.iD == voziloID);
	}
	public Vozilo[] GetAll() {
        return WindowsFormsApplication1.BAZA.seznamVozil.ToArray();
	}
	public bool VoziloKritièno() {
        foreach (var opravilo in this.opravila)
        {
            if (opravilo.JeOpraviloKritièno()) return true;
        }
        return false;
	}
	public string Izpis() {
        return "ID: " + this.iD + ", Znamka:" + this.znamka + ", " + this.model;
	}
	public Opravilo[] VsaKritiènaOpravila() {
        List<Opravilo> kritiènaOpravila;
        kritiènaOpravila = this.opravila.Where(t => t.JeOpraviloKritièno() == true).ToList();
        return kritiènaOpravila.ToArray();
	}
    
    public Vozilo IzlušèiVozilo(string izpis)
    {
        string niz = izpis;
        niz = niz.Remove(0, 4);
        niz = niz.Remove(1);
        if (AliVoziloObstaja(int.Parse(niz)))
        {
            return GetVozilo(int.Parse(niz));
        }
        else throw new Exception("Nemogoè dostop iz lista do vozila");
    }



}
