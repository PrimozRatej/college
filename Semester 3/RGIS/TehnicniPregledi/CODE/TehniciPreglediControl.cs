using System.Collections.Generic;
using System.Windows.Forms;
public class TehnicniPreglediControl {
    public TehnicniPreglediControl()
    {

    }

    List<TehnicniPregledi> seznamTehni�nihPregledov;
	public TehnicniPregledi[] vrniTehni�nePreglede(Vozilo vozilo1)//TODO popravi
    {
        return new TehnicniPregledi().GetTehni�nePreglede(vozilo1);

	}
	public bool NastaviTehni�nePreglede(TehnicniPregledi tehPre) {
		throw new System.Exception("Not implemented");
	}
	public void IzpisTehni�nihPregledov(List<TehnicniPregledi> seznam) {
        string niz = "";
        foreach (var Tehni�niPregled in seznam)
        {
            niz = niz+Tehni�niPregled.Izpis();
        }
        MessageBox.Show(niz);
        
	}


}
