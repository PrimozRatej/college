$(function(event) {

    //var forma = $("#forma");
    var sliderVrednost = 0;

    $("#forma_isci").submit(function(event){
        event.preventDefault();
        $( ".table:eq(1) tbody tr").removeClass("green");;
        var niz = $("#iskalniNiz").val();
        if (niz == "") {
            $("#obvestila").text("Vnesli ste prazen niz")
            $("#obvestila").attr("class","bg-danger");
        }
        else
        {
            $("#obvestila").text("Iskali ste po nizu "+niz);
            $("#obvestila").attr("class","dg-success");
            var indexi = Isci(niz);
            var kandidatiPolje = PridobiPolje();
            for(var i = 0;i<indexi.length;i++)
            {
                var indeks = indexi[i];
                var idKandidata = kandidatiPolje[indeks].id;
                var vrstica = $( ".table:eq(1) tbody tr" ).has("a[data-id='"+idKandidata+"']");
                vrstica.addClass("green");

            }
        }

    });


    $("#vnosKandidatov").hide();
    $("#gumbVnosKandidatov").click(function(event) {
        event.preventDefault();
        $("#vnosKandidatov").toggle(500);
    });


    $("#stDelegatovVrednost").text(0);
    $( ".delegatiSlider" ).slider({
        min:0,
        max:3000,
        step:1,
        change: function(event,ui){
            sliderVrednost = ui.value;
            $("#stDelegatovVrednost").text(ui.value);
        }

    });
    //var obvestila = $("#obvestila");

    $("#forma").submit(function (event)
    {
        event.preventDefault();
        var id = $("#id").val();
        var ime = $("#ime").val();
        var priimek = $("#priimek").val();
        var stranka = $("#stranka").val();
        var stDelegatov = sliderVrednost;
        if(id == "") {
            try {
                var kandidat = KandidatObjekt(ime, priimek, stranka, stDelegatov);
                DodajKandidataNaPolje(kandidat);
                $("#obvestila").attr("class","dg-success");
                $("#obvestila").text("");
            }
            catch (error) {
                $("#obvestila").text("Nepravilen vnos");
                $("#obvestila").attr("class","bg-danger");
            }
        }
        else
        {
            var posodobi = IsciPoID(id);
            posodobi.PosodobiZapis(ime, priimek, stranka, stDelegatov);
        }

        OblikujIzpis(PridobiPolje());
        this.reset();
        $("#id").val("");
        $("#stDelegatovVrednost").text(0);
        $( ".delegatiSlider" ).slider({
            value: 0
        });
        $("#pobrisi").click(function(){
            PobrisiPolje()
            OblikujIzpis(PridobiPolje());
        });

    });

    $('form').on('reset', function(event)
    {
        event.preventDefault();
        $("#ime").val("");
        $("#priimek").val("");
        $("#stranka").val("");
        $( ".delegatiSlider" ).slider({
            value: 0
        });
        $("#stDelegatovVrednost").text(0);

    });






});












