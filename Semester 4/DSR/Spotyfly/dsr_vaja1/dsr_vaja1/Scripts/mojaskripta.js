$(document).ready(function()
{
   
    $(function () {
        $("#tabs").tabs();
    });

    $(function () {
        $("#slider-range-starost").slider({
            range: "min",
            value: 24,
            min: 1,
            max: 120,
            slide: function (event, ui) {
                $("#Starost").val(ui.value);
            }
        });
        $("#Starost").val($("#slider-range-starost").slider("value"));
    });

   
    $(function () {
        $("#datepicker").datepicker({
            changeMonth: true,
            changeYear: true,
            dateFormat: "dd/mm/yy",
            yearRange: '1900:2017'
        });
    });
  

    $(function () {
        $("#slider-range-cena").slider({
            range: "min",
            min: 1,
            max: 500,
            value: 100,
            step: 0.5,
            slide: function (event, ui) {
                $("#cena").val(ui.value);
            }
        });
        $("#cena").val($("#slider-range-cena").slider("value"));
    });

    $(function () {
        $("#slider-range-zaloga").slider({
            range: "min",
            min: 1,
            value: 10,
            max: 100,
            slide: function (event, ui) {
                $("#zaloga").val(ui.value);
            }
        });
        $("#zaloga").val($("#slider-range-zaloga").slider("value"));
    });
})


