$(function () {
	if(localStorage.getItem("mojiFilmi") == null)
	{
		var filmi = [];
		$('div[role="alert"]').hide()
	}
	else
	{
		$('div[role="alert"]').hide()
		var filmi = JSON.parse(localStorage.getItem("mojiFilmi"));
		for(var i = 0;i<filmi.length;i++)
		{
			$(".list-group").append('<li>'+ filmi[i].naslov + ' - ' + '<a href="#nothing">Odstrani</a></li>');
			$("li").addClass("list-group-item");
		}
	}
	$("tr .btn").click(function () {
		var currentRow=$(this).closest("tr"); 
        var id=currentRow.find("td:eq(0)").html(); 
        var naslov=currentRow.find("td:eq(1)").html(); 
        var letnica=currentRow.find("td:eq(2)").html();
		var zvrst=currentRow.find("td:eq(3)").html();

		var film = {
		 'id': id,
		 'naslov': naslov,
		 'letnica': letnica,
		 'zvrst': zvrst,
		};
		filmi = localStorage.getItem("mojiFilmi");
		filmi = JSON.parse(filmi);
		if(filmi == null)
		{
			filmi = [];
			filmi.push(film);
			localStorage.setItem("mojiFilmi", JSON.stringify(filmi));
			$('div[role="alert"]').show().html("Film " + "<b>" + film.naslov + "</b>" + " je bil usepesno dodan!").addClass("alert alert-success");
			$(".list-group").append('<li>'+ film.naslov + ' - ' + '<a href="#nothing">Odstrani</a></li>');
			$("li").addClass("list-group-item");
		}
		else if(filmi != null)
		{
			var filmDodan = false;
			filmi.forEach( function (x)
			{
				if(x.id == film.id)
				{
					$('div[role="alert"]').show().html("Film " + "<b>" + film.naslov + "</b>" + " je ze dodan!").removeClass().addClass("alert alert-danger");
					filmDodan = true;			
				}
			});
			if(filmDodan == false)
			{
				filmi.push(film);
				localStorage.setItem("mojiFilmi", JSON.stringify(filmi));
				$('div[role="alert"]').show().html("Film " + "<b>" + film.naslov + "</b>" + " je bil usepesno dodan!").removeClass().addClass("alert alert-success");
				$(".list-group").append('<li>'+ film.naslov + ' - ' + '<a href="#nothing">Odstrani</a></li>');
				$("li").addClass("list-group-item");
			}
		}
	});
	$(document).on("click", "a", function(){
		var data = (this).closest("li").childNodes[0].data.replace('-','').trim();
		$(this).closest("li").remove();
		filmi = JSON.parse(localStorage.getItem("mojiFilmi"));
		for(var i= 0;i<filmi.length;i++)
		{
			if(filmi[i].naslov == data)
			{
				filmi.splice(i,1);			
			}
		}
		$('div[role="alert"]').show().html("Film " + "<b>" + data + "</b>" + " je bil izbrisan!").removeClass().addClass("alert alert-info");
		localStorage.setItem("mojiFilmi", JSON.stringify(filmi));
	});
	window.onload = function() {
        filmi = JSON.parse(localStorage.getItem("mojiFilmi"));
		if(filmi !== null)
		{
			filmi.forEach( function (x)
			{	
				$(".list-group").append('<li>'+ x.naslov + ' - ' + '<a href="#nothing">Odstrani</a></li>');
			});
		}
    }
});