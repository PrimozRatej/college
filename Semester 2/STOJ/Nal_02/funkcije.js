/**
 * Created by Primož on 20. 04. 2016.
 */

var objekti = [];


function DolzinaPolja(){
    //document.getElementById("label").innerHTML = cars.length;
    return objekti.length;
}

function UstvariObjekt(ime,priimek,stranka)
{
    if(ime == null||priimek==null||stranka == null) window.alert("Parametri niso popolni!");
    else
    {
        var oseba = {ime:ime, priimek:priimek, stranka:stranka};
        objekti.push(oseba);

    }
    return oseba;
    //return null;

}

function  OdstraniIzPolja(index)
{
    var array = [];
    if(index>=objekti.length){window.alert("Polje ni tako veliko");}
    for(var i = 0;i<objekti.length;i++) {
        if (index != i) array.push(objekti[i]);
    }

    for(var i = 0;i<objekti.length;)
    {
        objekti.splice(i);
    }

    for(var i = 0;i<array.length;i++)
    {
        objekti.push(array[i]);
    }
    return true;

}


function IzpisiPosameznega(index)
{
    for(var i = 0; i<objekti.length;i++)
    {
        if (index == i) {
            return "Osebi je ime " + objekti[i].ime + ". piše se " + objekti[i].priimek + " pripada pa stranki " + objekti[i].stranka + ".";
        }
    }
    return;
}

function IsciPoImenu(besedilo)
{
    for(var i = 0;i<objekti.length;i++)
    {
        if (besedilo == objekti[i].ime) return IzpisiPosameznega(i);
    }
    return "Ni takšnega Imena";
}














