using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using tocilnicaPijace_naloga01;

namespace tocilnicaPijace_naloga02
{
    class XmlParser
    {

        public List<Artikel> Artikli (string xmlFileName)
        {
            XmlDocument doc = new XmlDocument();
            List<Artikel> listArtikel = new List<Artikel>();
            doc.Load(xmlFileName);
            foreach (XmlNode node in doc.DocumentElement)
            {
                string id_niz = node.Attributes[0].Value;
                int id = int.Parse(id_niz.Trim('a').ToString());
                string naziv = node["naziv"].InnerText;
                double kolicina = double.Parse(node["kolicina"].InnerText);
                double znesek = double.Parse(node["cena"].ChildNodes[0].InnerText);
                string valuta = node["cena"].ChildNodes[1].Attributes[0].Value;
                int zaloga = int.Parse(node["zaloga"].InnerText);
                int dobId = int.Parse(node["dobaviteljId"].InnerText);
                //DateTime datumZadnjeNabave = DateTime.ParseExact(node["datumZadnjeNabave"].InnerText, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime datumZadnjeNabave = new DateTime();
                DateTime.TryParse(node["datumZadnjeNabave"].InnerText, CultureInfo.CurrentUICulture, DateTimeStyles.None, out datumZadnjeNabave);
                Artikel art = new Artikel(id, naziv, kolicina, zaloga, znesek, Artikel.GetTip(valuta), datumZadnjeNabave, dobId);
                listArtikel.Add(art);
            }
            return listArtikel;
        }

        public List<Dobavitelj> Dobavitelji(string xmlFileName)
        {
            XmlDocument doc = new XmlDocument();
            List<Dobavitelj> listDobaviteljev = new List<Dobavitelj>();
            doc.Load(xmlFileName);
            foreach (XmlNode node in doc.DocumentElement)
            {
                string id_niz = node.Attributes[0].Value;
                int id = int.Parse(id_niz.Trim('d').ToString());
                string naziv = node["naziv"].InnerText;
                string ime = node["ime"].InnerText;
                string priimek = node["priimek"].InnerText;
                string ulica = node["naslov"].ChildNodes[0].InnerText;
                string stevilka = node["naslov"].ChildNodes[1].InnerText;
                string posta = node["naslov"].ChildNodes[2].ChildNodes[0].InnerText;
                int p_stevilka = int.Parse(node["naslov"].ChildNodes[2].ChildNodes[1].InnerText);
                Dobavitelj dob = new Dobavitelj(id, naziv, ime, priimek, ulica, stevilka, posta, p_stevilka);
                listDobaviteljev.Add(dob);
            }
            return listDobaviteljev;
        }

        internal void removeArtikel(Artikel artikel, string xmlFileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFileName);
            foreach (XmlNode node in doc.DocumentElement)
            {
                string id_niz = node.Attributes[0].Value;
                int id = int.Parse(id_niz.Trim('a').ToString());
                if (id == artikel.id)
                {
                    doc.DocumentElement.RemoveChild(node);
                    doc.Save(Dobavitelj.filePathDobavitelji);
                }
            }
        }

        public void AddArtikel(Artikel artikel, string xmlFileName)
        {
            
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlFileName);
                XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
                XmlNode skladisce = doc.SelectSingleNode("skladisce", nsmgr);

                XmlElement artikel_el = doc.CreateElement("artikel");
                artikel_el.SetAttribute("id", "a"+artikel.id.ToString());
                XmlElement naziv = doc.CreateElement("naziv");
                naziv.InnerText = artikel.naziv;
                XmlElement kolicina = doc.CreateElement("kolicina");
                kolicina.InnerText = artikel.kolicina.ToString();
                XmlElement cena = doc.CreateElement("cena");
                XmlElement znesek = doc.CreateElement("znesek");
                znesek.InnerText = artikel.znesek.ToString();
                XmlElement valuta = doc.CreateElement("valuta");
                valuta.SetAttribute("tip", artikel.valuta.ToString());
                valuta.IsEmpty = true;
                XmlElement zaloga = doc.CreateElement("zaloga");
                zaloga.InnerText = artikel.zaloga.ToString();
                XmlElement datumZadnjeNabave = doc.CreateElement("datumZadnjeNabave");
                datumZadnjeNabave.InnerText = artikel.datumZadnjeNabave.ToString();
                XmlElement dobaviteljId = doc.CreateElement("dobaviteljId");
                dobaviteljId.InnerText = artikel.dobaviteljId.ToString();

                cena.AppendChild(znesek);
                cena.AppendChild(valuta);
                artikel_el.AppendChild(naziv);
                artikel_el.AppendChild(kolicina);
                artikel_el.AppendChild(cena);
                artikel_el.AppendChild(zaloga);
                artikel_el.AppendChild(datumZadnjeNabave);
                artikel_el.AppendChild(dobaviteljId);

                skladisce.AppendChild(artikel_el);
                doc.Save(xmlFileName);
        }

        public void addDobavitelj(Dobavitelj dob, string xmlFileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFileName);
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            XmlNode dobavitelji = doc.SelectSingleNode("dobavitelji", nsmgr);
            XmlElement dobavitelj = doc.CreateElement("dobavitelj");
            dobavitelj.SetAttribute("id", "d" + dob.Id);
            XmlElement naziv = doc.CreateElement("naziv");
            naziv.InnerText = dob.Naziv;
            XmlElement ime = doc.CreateElement("ime");
            ime.InnerText = dob.Ime;
            XmlElement priimek = doc.CreateElement("priimek");
            priimek.InnerText = dob.Priimek;
            XmlElement naslov = doc.CreateElement("naslov");
            XmlElement ulica = doc.CreateElement("ulica");
            ulica.InnerText = dob.Ulica;
            XmlElement stevilka = doc.CreateElement("stevilka");
            stevilka.InnerText = dob.Stevilka;
            XmlElement posta = doc.CreateElement("posta");
            XmlElement kraj = doc.CreateElement("kraj");
            kraj.InnerText = dob.Posta;
            XmlElement p_stevilka = doc.CreateElement("p_stevilka");
            p_stevilka.InnerText = dob.PostnaStevilka.ToString();

            posta.AppendChild(kraj);
            posta.AppendChild(p_stevilka);
            naslov.AppendChild(ulica);
            naslov.AppendChild(stevilka);
            naslov.AppendChild(posta);
            dobavitelj.AppendChild(naziv);
            dobavitelj.AppendChild(ime);
            dobavitelj.AppendChild(priimek);
            dobavitelj.AppendChild(naslov);

            dobavitelji.AppendChild(dobavitelj);
            doc.Save(xmlFileName);
        }

        public bool removeDobavitelj(Dobavitelj dobavitelj, string xmlFileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFileName);
            foreach (XmlNode node in doc.DocumentElement)
            {
                string id_niz = node.Attributes[0].Value;
                int id = int.Parse(id_niz.Trim('d').ToString());
                if(id == dobavitelj.Id)
                {
                    doc.DocumentElement.RemoveChild(node);
                    doc.Save(Dobavitelj.filePathDobavitelji);
                }
            }
            return true;
        }


    }
}
