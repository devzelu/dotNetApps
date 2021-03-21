
$(document).ready(function () {

    var idZawodnika = $("#txtIdZawodnika").val()

    $.ajax({
        method: "POST",
        url: location.origin + "/API/ZawodnikEdycjaTrenerzy.aspx",
        data: { name: "John", location: "Boston" }
    })
        .done(function (msg) {

              // alert("Data Saved: " + msg);

            var tabTrenerzy = JSON.parse(msg);

            for (var i = 0; i < tabTrenerzy.length; i++) {
                $("#dvListaTrenerow").append(
                    '<a class="dropdown-item" ' +
                    'data-idTrenera="' + tabTrenerzy[i].Id + '" href="#">' +
                    tabTrenerzy[i].Imie + ' ' +
                    tabTrenerzy[i].Nazwisko + '</a>'
                );
            }

            // tutaj deserializacja 
            //var obj = JSON.parse(msg);

            //$("#txtDane").val(obj[0].Nazwisko);

        });

    //$("#btnPodajDane").click(function () {

    //    // tutaj będziemy wysyłać prośbę do serwera
    //    //o dane



    //});

});