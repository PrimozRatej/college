using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using UrnikGooG.Ogrodje;

namespace UrnikGooG
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        /// <summary>
        /// /// <method>GET</method>
        /// http://localhost:57982/Storitev/Service1.svc/Zaposleni
        /// </summary>
        public List<Zaposleni> getZaposlene()
        {
            return Zaposleni.getZaposlene();
        }

        /// <summary>
        /// <method>GET</method>
        /// http://localhost:57982/Storitev/Service1.svc/Zaposleni/2
        /// </summary>
        public Zaposleni getZaposleni(string id)
        {
            Zaposleni zap = Zaposleni.getZaposlen(int.Parse(id));
            return zap;
        }
        /// <summary>
        /// <method>POST</method>
        /// http://localhost:57982/Storitev/Service1.svc/zaposleni
        /// </summary>
        public void insertZaposleni(Zaposleni zaposleni)
        {
            if(Zaposleni.insertZaposlen(zaposleni))//If insert == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/zaposleni/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, zaposleni.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }
        public void updateZaposleni(Zaposleni zaposleni)
        {
            if (Zaposleni.updateZaposleni(zaposleni))//If update == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/zaposleni/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, zaposleni.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        public void deleteZaposleni(string id)
        {
            if (Zaposleni.deleteZaposleni(id))//If update == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/zaposleni/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }


        //PROSTI DAN
        public ProstiDan prostiDan_get(string id)
        {
            return ProstiDan.get(int.Parse(id));
        }

        public List<ProstiDan> prostiDan_getAll()
        {
            return ProstiDan.getAll();
        }

        public void prostiDan_insert(ProstiDan date)
        {
            if(ProstiDan.insert(date))//If insert == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/prostiDan/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, date.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
           
        }

        public void prostiDan_update(ProstiDan date)
        {
            if (ProstiDan.update(date))//If update == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/zaposleni/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, date.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        public void prostiDan_delete(string id)
        {
            if (ProstiDan.delete(int.Parse(id)))//If delete == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/zaposleni/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        //BOLNISKA
        public Bolniška getBolniška(string id)
        {
            return Bolniška.get(int.Parse(id));
        }

        public List<Bolniška> getBolniške()
        {
            return Bolniška.get();
        }

        public void insertBolniške(Bolniška bol)
        {
            if (Bolniška.insert(bol))//If insert == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/bolniska/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, bol.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        public void updateBolniška(Bolniška bol)
        {
            if (Bolniška.update(bol))//If update == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/bolniska/{Id}"); //<--
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, bol.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        public void deleteBolniška(string id)
        {
            if (Bolniška.delete(int.Parse(id)))//If update == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/bolniska/{Id}"); //<--
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        // DOPUST
        public Dopust getDopust(string id)
        {
            return Dopust.get(int.Parse(id));
        }

        public List<Dopust> getAllDopust()
        {
            return Dopust.getAll();
        }

        public void insertDopust(Dopust dop)
        {
            if (Dopust.insert(dop))//If insert == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/dopust/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, dop.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        public void updateDopust(Dopust dop)
        {
            if (Dopust.update(dop))//If update == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/dopust/{Id}"); //<--
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, dop.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        public void deleteDopust(string id)
        {
            if (Dopust.delete(int.Parse(id)))//If update == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/dopust/{Id}"); //<--
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }
        // TIP OPRAVILA
        public TipOpravila getTipOpravila(string id)
        {
            return TipOpravila.get(int.Parse(id));
        }

        public List<TipOpravila> getAllTipOpravila()
        {
            return TipOpravila.getAll();
        }

        public void insertTipOpravila(TipOpravila tipOpr)
        {
            if (TipOpravila.insert(tipOpr))//If insert == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/tipOpravila/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, tipOpr.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        public void updateTipOpravila(TipOpravila tipOpr)
        {
            if (TipOpravila.update(tipOpr))//If insert == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/tipOpravila/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, tipOpr.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        public void deleteTipOpravila(string id)
        {
            if (TipOpravila.delete(int.Parse(id)))//If insert == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/tipOpravila/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }
        //OPRAVILO
        public Opravilo getOpravilo(string id)
        {
            return Opravilo.get(int.Parse(id));
        }

        public List<Opravilo> getAllOpravilo()
        {
            return Opravilo.getAll();
        }

        public void insert(Opravilo opra)
        {
            if (Opravilo.insert(opra))//If insert == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/opravilo/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, opra.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        public void update(Opravilo opra)
        {
            if (Opravilo.update(opra))//If insert == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/opravilo/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, opra.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        public void delete(string id)
        {
            if (Opravilo.delete(int.Parse(id)))//If insert == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/opravilo/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }
        //IZMENA
        public Izmena getIzmena(string id)
        {
            return Izmena.get(int.Parse(id));
        }

        public List<Izmena> getAllIzmena()
        {
            return Izmena.getAll();
        }

        public void insertIzmena(Izmena izm)
        {
            if (Izmena.insert(izm))//If insert == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/izmena/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, izm.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        public void updateIzmena(Izmena izm)
        {
            if (Izmena.update(izm))//If insert == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/izmena/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, izm.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        public void deleteIzmena(string id)
        {
            if (Izmena.delete(int.Parse(id)))//If delete == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/izmena/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        //URNIK
        public Urnik getUrnik(string id)
        {
            return Urnik.getUrnik(int.Parse(id));
        }

        public List<Urnik> getUrnike()
        {
            return Urnik.getUrnike();
        }

        public void insertUrnik(Urnik izm)
        {
            if (Urnik.insertUrnik(izm))//If insert == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/izmena/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, izm.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

        public void updateUrnik(Urnik izm)
        {
            if (Urnik.updateUrnik(izm))//If insert == true
            {
                UriTemplateMatch match = WebOperationContext.Current.IncomingRequest.UriTemplateMatch;
                UriTemplate template = new UriTemplate("/izmena/{Id}");
                Uri novZaposlenUri = template.BindByPosition(match.BaseUri, izm.Id.ToString());
                WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated(novZaposlenUri);
            }
        }

       

    }
}
