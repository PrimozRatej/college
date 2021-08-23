using System.Collections.Generic;
using System.Windows.Forms;
public class TehnicniPreglediControl {
    public TehnicniPreglediControl()
    {

    }

    List<TehnicniPregledi> seznamTehniènihPregledov;
	public TehnicniPregledi[] vrniTehniènePreglede(Vozilo vozilo1)//TODO popravi
    {
        return new TehnicniPregledi().GetTehniènePreglede(vozilo1);

	}
	public bool NastaviTehniènePreglede(TehnicniPregledi tehPre) {
		throw new System.Exception("Not implemented");
	}
	public void IzpisTehniènihPregledov(List<TehnicniPregledi> seznam) {
        string niz = "";
        foreach (var TehnièniPregled in seznam)
        {
            niz = niz+TehnièniPregled.Izpis();
        }
        MessageBox.Show(niz);
        
	}


}
