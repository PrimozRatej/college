$(function(){
	$('.card').hide();
	var polje = filmi.Movies;
	for(var i = 0;i<polje.length;i++)
	{
		var naslov = polje[i].Title;
		$(".list-group:first").append("<li>" + naslov + "</li>")
		$(".list-group:first li").each(function(n) {
            $(this).attr("data-id", polje[n].imdbID);
		});
		$(".list-group:first li").addClass("list-group-item")
		$(".list-group:first li").addClass("list-group-item-action");
	}
	$('.list-group:first li').click(function(e) 
    { 
		$('.card').show();
    });
	$(".btn").click(function() 
    { 
		$('.card').hide();
    });
});