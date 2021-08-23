// Code goes here
$(function() {
	$(".btn").click(function () {
		event.preventDefault();
		$.ajax({
            type: "get",
            url: "https://api.tvmaze.com/search/shows?q=" + $("#nanizankaInput").val(),
			dataType: "json",
            success:function(data){
				$(".table tbody tr").remove()
				$(".col li").remove()
				for(var a = 0;a<data.length;a++)
				{
					var ocena = data[a].show.rating.average;
					if(ocena == null)
					{
						$('.table tbody').append('<tr><th>'+data[a].show.id+'</th>'+'<th>'+data[a].show.name+'</th>'+'<th>Ni ocene</th></tr>');
						$('.table tr:last').addClass("table-danger");
					}
					 else if(ocena <= 5)
					{
						$('.table tbody').append('<tr><th>'+data[a].show.id+'</th>'+'<th>'+data[a].show.name+'</th>'+'<th>'+data[a].show.rating.average+'</th></tr>');
						$('.table tr:last').addClass("table-danger");
					}
					else if(ocena > 5 && ocena < 7)
					{
						$('.table tbody').append('<tr><th>'+data[a].show.id+'</th>'+'<th>'+data[a].show.name+'</th>'+'<th>'+data[a].show.rating.average+'</th></tr>');
						$('.table tr:last').addClass("table-info");
					}
					else if(ocena >= 7)
					{
						$('.table tbody').append('<tr><th>'+data[a].show.id+'</th>'+'<th>'+data[a].show.name+'</th>'+'<th>'+data[a].show.rating.average+'</th></tr>');
						$('.table tr:last').addClass("table-success").att;
					}
				}
             }
        });
	});
	$("tbody").delegate('tr', 'click', function() {
		var id = $(this).find("th:first").text();
		$.ajax({
            type: "get",
            url: "https://api.tvmaze.com/shows/" + id + "/cast",
			dataType: "json",
            success:function(data){
				if($(".col ul").hasClass("list-group-item-danger")){
					$(".col ul").removeClass("list-group-item-danger");
				}
				$(".col li").remove()
				if(data.length == 0)
				{
					$(".col ul").append('<li>Ni podatka o igralcih</li>');
					$(".col li").addClass("list-group-item-danger");
				}
				else{
					for(var a = 0;a<data.length;a++)
					{
						$(".col ul").append('<li>'+ data[a].person.name + "..." + data[a].character.name +'</li>');
					}
				}
			}
		});
	});
});