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
    [ServiceContract]
    public interface IService1
    {
        //ZAPOSLENI
        [OperationContract]
        [WebGet(UriTemplate = "zaposleni/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Zaposleni getZaposleni(string id);

        [OperationContract]
        [WebGet(UriTemplate = "zaposleni", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        List<Zaposleni> getZaposlene();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "zaposleni", BodyStyle = WebMessageBodyStyle.Bare)]
        void insertZaposleni(Zaposleni zaposleni);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "zaposleni", BodyStyle = WebMessageBodyStyle.Bare)]
        void updateZaposleni(Zaposleni zaposlen);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "zaposleni/{id}")]
        void deleteZaposleni(string id);


        //PROSTI DAN
        [OperationContract]
        [WebGet(UriTemplate = "prostiDan/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        ProstiDan prostiDan_get(string id);

        [OperationContract]
        [WebGet(UriTemplate = "prostiDnevi", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        List<ProstiDan> prostiDan_getAll();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "prostiDan", BodyStyle = WebMessageBodyStyle.Bare)]
        void prostiDan_insert(ProstiDan date);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "prostiDan", BodyStyle = WebMessageBodyStyle.Bare)]
        void prostiDan_update(ProstiDan date);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "prostiDan/{id}")]
        void prostiDan_delete(string id);
        // BOLNIŠKA
        [OperationContract]//TO DO Nastavi parametre na string
        [WebGet(UriTemplate = "bolniska/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Bolniška getBolniška(string id);
        [OperationContract]
        [WebGet(UriTemplate = "bolniske", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        List<Bolniška> getBolniške();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "bolniska", BodyStyle = WebMessageBodyStyle.Bare)]
        void insertBolniške(Bolniška bol);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "bolniska", BodyStyle = WebMessageBodyStyle.Bare)]
        void updateBolniška(Bolniška bol);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "bolniska/{id}")]
        void deleteBolniška(string id);
        //DOPUST
        [OperationContract]//TO DO Nastavi parametre na string
        [WebGet(UriTemplate = "dopust/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Dopust getDopust(string id);

        [OperationContract]
        [WebGet(UriTemplate = "dopust", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        List<Dopust> getAllDopust();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "dopust", BodyStyle = WebMessageBodyStyle.Bare)]
        void insertDopust(Dopust dop);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "dopust", BodyStyle = WebMessageBodyStyle.Bare)]
        void updateDopust(Dopust dop);
        
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "dopust/{id}")]
        void deleteDopust(string id);

        // TIP OPRAVILA
        //Privzeto je GET
        [OperationContract]//TO DO Nastavi parametre na string
        [WebGet(UriTemplate = "tipOpravila/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        TipOpravila getTipOpravila(string id);

        [OperationContract]
        [WebGet(UriTemplate = "tipOpravila", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        List<TipOpravila> getAllTipOpravila();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "tipOpravila", BodyStyle = WebMessageBodyStyle.Bare)]
        void insertTipOpravila(TipOpravila tipOpr);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "tipOpravila", BodyStyle = WebMessageBodyStyle.Bare)]
        void updateTipOpravila(TipOpravila tipOpr);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "tipOpravila/{id}", BodyStyle = WebMessageBodyStyle.Bare)]
        void deleteTipOpravila(string id);

        // OPRAVILO
        [OperationContract]//TO DO Nastavi parametre na string
        [WebGet(UriTemplate = "opravilo/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Opravilo getOpravilo(string id);

        [OperationContract]//TO DO Nastavi parametre na string
        [WebGet(UriTemplate = "opravilo", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        List<Opravilo> getAllOpravilo();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "opravilo", BodyStyle = WebMessageBodyStyle.Bare)]
        void insert(Opravilo opra);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "opravilo", BodyStyle = WebMessageBodyStyle.Bare)]
        void update(Opravilo opra);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "opravilo/{id}", BodyStyle = WebMessageBodyStyle.Bare)]
        void delete(string id);

        //IZMENA
        [OperationContract]
        [WebGet(UriTemplate = "izmena/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Izmena getIzmena(string id);

        [OperationContract]
        [WebGet(UriTemplate = "izmena", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        List<Izmena> getAllIzmena();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "izmena", BodyStyle = WebMessageBodyStyle.Bare)]
        void insertIzmena(Izmena izm);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "izmena", BodyStyle = WebMessageBodyStyle.Bare)]
        void updateIzmena(Izmena izm);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "izmena/{id}", BodyStyle = WebMessageBodyStyle.Bare)]
        void deleteIzmena(string id);





        //URNIK
        [OperationContract]
        [WebGet(UriTemplate = "urnik/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Urnik getUrnik(string id);

        [OperationContract]
        [WebGet(UriTemplate = "urnik", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        List<Urnik> getUrnike();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "urnik", BodyStyle = WebMessageBodyStyle.Bare)]
        void insertUrnik(Urnik urnik);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "urnik", BodyStyle = WebMessageBodyStyle.Bare)]
        void updateUrnik(Urnik urnik);

       









    }



}
