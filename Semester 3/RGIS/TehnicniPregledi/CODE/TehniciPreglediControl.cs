using System.Collections.Generic;
using System.Windows.Forms;
public class TehnicniPreglediControl {
    public TehnicniPreglediControl()
    {

    }

    List<TehnicniPregledi> seznamTehničnihPregledov;
	public TehnicniPregledi[] vrniTehničnePreglede(Vozilo vozilo1)//TODO popravi
    {
        return new TehnicniPregledi().GetTehničnePreglede(vozilo1);

	}
	public bool NastaviTehničnePreglede(TehnicniPregledi tehPre) {
		throw new System.Exception("Not implemented");
	}
	public void IzpisTehničnihPregledov(List<TehnicniPregledi> seznam) {
        string niz = "";
        foreach (var TehničniPregled in seznam)
        {
            niz = niz+TehničniPregled.Izpis();
        }
        MessageBox.Show(niz);
        
	}


}
