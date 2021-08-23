// Code goes here
$(document).ready(function(){	
	var stevec = $(".list-group-item").lenght;
	$("#stKomentarjev").text(stevec);
	$(".list-group").toggle();
	$(".notification").hide();
	$( "#dialog" ).dialog({
		autoOpen: false,
		buttons: [
		{
			text: "Dodaj",
			click: function() {
				var vz = $("#vzdevek").val();
				var ko = $("#komentar").val();
				if(vz == "" && ko == "")
				{
					$(".notification").show();
				}
				else if(ko == "" && vz != "")
				{
					$(".notification:last").show();
					$(".notification:first").hide();
				}
				else if(vz == "" && ko != "")
				{
					$(".notification:first").show();
					$(".notification:last").hide();
				}
				else{
					if($(".list-group-item").is( ":hidden" ))
					{
						$(".card-link:first").text("Skrij komentarje");
						$(".list-group").toggle("fold", 1000);
					}
					$(this).dialog( "close" );
					$(".list-group-flush").append("<li class='list-group-item'><h5 class='w-100'>" + vz + "</h5>" + ko + "</li>");
					$(".list-group-item:last").addClass("list-group-item-success",500).delay(2000).queue(function(next){
							$(this).removeClass("list-group-item-success",500);
							next();
						});
					$("#vzdevek").val("");
					$("#komentar").val("");					
				}
			}
		},
		{
			text: "Prekliči",
			click: function() {
				$(this).dialog( "close" );
				$("#vzdevek").val("");
				$("#komentar").val("");
			}
		}
		]
	});

	$(".card-link:first").click(function(){
		if($(".list-group-item").is( ":visible" ))
		{
			$(".card-link:first").text("Prikaži komentarje");
			$(".list-group").toggle("fold", 1000);
		}
		if($(".list-group-item").is( ":hidden" ))
		{
			$(".card-link:first").text("Skrij komentarje");
			$(".list-group").toggle("fold", 1000);
		}	
	});
	$(".card-link:last").click(function(){
		$( "#dialog" ).dialog( "open" );
	});
});