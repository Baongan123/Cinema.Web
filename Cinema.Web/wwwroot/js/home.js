var home = {} || home;

home.drawTable = function () {
    $.ajax({
        url: "/Home/Gets",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#tbDepart tbody').empty();
            $.each(data.films, function (i, v) {
                $('#tbDepart tbody').append(
                    `<tr>
                        <td>${v.filmId}</td>
                        <td>${v.filmName}</td>
                        <td>${v.title}</td>
                        <td>${v.description}</td>
                        <td>${v.linkTrailer}</td>
                        <td><img src="${v.image}" width="100" height="100" /></td>
                        
                    </tr>`
                );
            });
        }
    });

};
home.init = function () {
    home.drawTable();
};

$(document).ready(function () {
    home.init();
});