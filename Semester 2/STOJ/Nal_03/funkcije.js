var poljeKandidatov = new Array();
function KandidatObjekt (ime,priimek,stranka,steviloDelegatov)
{
    if (ime === ""||priimek === "")
    {
        $("#obvestila").text("Vnesli ste prazen niz");
        return;
    }
    else
    {
        var Kandidat = {
            id:poljeKandidatov.length+1,
            ime:ime, priimek:priimek,
            stranka:stranka,
            stDelegatov:steviloDelegatov,
            PosodobiZapis : function(ime,priimek,stranka,steviloDelegatov)
            {
                this.ime = ime;
                this.priimek = priimek;
                this.stranka = stranka;
                this.stDelegatov = steviloDelegatov;
                return this;
            }

        };
    }

    return Kandidat;
}

function OblikujIzpis()
{
    var polje = PridobiPolje();
    $(".table").eq(1).find("tr:gt(0)").remove();
    for(var i = 0;i<polje.length;i++)
    {
        $(".table").eq(1).find("tbody").append(
            "<tr>" +
            "<td>" + polje[i].id + "</td>" +
            "<td>" + polje[i].ime + " " + polje[i].priimek + "</td>" +
            "<td>" + polje[i].stranka + "</td>" +
            "<td>" + polje[i].stDelegatov + "</td>" +
            "<td><a href=" + "#" + " class=" + "uredi" + " data-id=" + polje[i].id + ">Uredi</a></td>" +
            "</tr>"
        );
    }
    var zadnjaVrstica = $(".table").eq(1).find("tbody tr:last-child");

    zadnjaVrstica.addClass("dodajZapis", 500, "swing", function () {
        setTimeout(function(){
            zadnjaVrstica.removeClass("dodajZapis",500);
        },1000)
    });
    $("a.uredi").click(function (event) {
        event.preventDefault();
        var taId = parseInt($(this).data("id"));
        var kan = IsciPoID(taId);
        $("#id").val(kan.id);
        $("#ime").val(kan.ime);
        $("#priimek").val(kan.priimek);
        $("#stranka").val(kan.stranka);
        $("#stDelegatovVrednost").text(kan.stDelegatov);
        $( ".delegatiSlider" ).slider({
            value: kan.stDelegatov
        });
    });

}


function IsciPoID(id)
{
    for(var i = 0;i<poljeKandidatov.length;i++)
    {
        if(id == poljeKandidatov[i].id) return poljeKandidatov[i];
    }
    return null;
}

function Isci(iskalniNiz)
{
    var vmesnoPolje = [];
    for(var i = 0;i<poljeKandidatov.length;i++)
    {
        var niz = poljeKandidatov[i].ime+" "+poljeKandidatov[i].priimek+" "+poljeKandidatov[i].stranka;
        if(niz.toLowerCase().indexOf(iskalniNiz.toLowerCase())>-1)
        {
            vmesnoPolje.push(i);
        }

    }
    return vmesnoPolje;
}

function DodajKandidataNaPolje(kandidat)
{
    poljeKandidatov.push(kandidat);
    return true;
}

function PridobiPolje()
{
    return poljeKandidatov;
}





function PobrisiPolje()
{
    poljeKandidatov.splice(0,poljeKandidatov.length);
}






