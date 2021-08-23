/**
 * Created by Primož on 20. 04. 2016.
 */
function main()
{
    document.getElementById("div1").innerHTML = "Tvojamamam";

    //funkcija ustvari objekt tudi naloži ta objekt na polje.
    UstvariObjekt("Primož","Ratej","Social Demokrat");
    UstvariObjekt("Jan","Prah","Demokrat");
    UstvariObjekt("Mila","Motic","Socialist");
    UstvariObjekt("Ljudmila","Novak","Še sama ne ve točno.");

    // OdstraniIzPolja(2);
    document.writeln(IzpisiPosameznega(0));
    document.writeln(IzpisiPosameznega(1));
    document.writeln(IzpisiPosameznega(3));
    //document.getElementById("div1").innerHTML =IzpisiPosameznega(2);

    document.writeln(IsciPoImenu("Mila"));
}
