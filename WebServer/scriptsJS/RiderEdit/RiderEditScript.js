
function TeamChange(idTeam, TeamName) {
    var idRider = $("#txtIdRider").val()

    $.ajax({
        method: "POST",
        url: location.origin + "/API/RiderEditTeams.aspx",
        data: { idTeam: idTeam, idRider: idRider }
    })
        .done(function (msg) {
            $("#navbarDropdownMenuLink2").html(
                decodeURI(TeamName));
        });

}

$(document).ready(function () {


   var idRider= $("#txtIdRider").val()

    $.ajax({
        method: "POST",
        url: location.origin +"/API/RiderEditTeams.aspx",
    })
        .done(function (msg) {

            //alert("Data fetched: " + msg);

            var tabTeams = JSON.parse(msg);

            for (var i = 0; i < tabTeams.length; i++) {
                var teamName = tabTeams[i].TeamName;
                $("#dvListaTeamow").append(
                    '<a onclick=TeamChange(' + tabTeams[i].Id + ',"' + encodeURI(teamName) + '") class="dropdown-item" ' +
                    'data-idTeam="' + tabTeams[i].Id + '" href="#">' +
                    teamName + '</a>'
                );

            }

       

        });

});