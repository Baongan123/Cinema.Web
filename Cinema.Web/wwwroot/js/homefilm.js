var film = {} || film;
var filmId = 0;
var link = `https://www.youtube.com/embed`;

film.drawFilm = function () {
    $.ajax({
        url: `/Film/Get/${filmId}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#Image').attr('src', data.film.image);
            $('#FilmName').empty()
            $('#FilmName').append(`<p>${data.film.filmName} </p>`);
            $('#Title').empty()
            $('#Title').append(`<p>${data.film.title} </p>`);
            $('#Description').empty();
            $('#Description').append(`<p>${data.film.description} </p>`);
            $('#trailer').attr('src', `${link}/${data.film.linkTrailer}`);
            film.initCategory(data.film.categoryId);

        }
    });
}
film.drawshowing = function () {
    $.ajax({
        url: `/Home/DayShowOfFilm/${filmId}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            var i = 0;
            for (i; i < data.dayshows.length; i++) {
                film.showing(data.dayshows[i].day, i);
            }
        }
    });
}
film.showing= function (day,id) {
    var saveObj = {};
    saveObj.FilmId = parseInt(filmId);
    saveObj.DayShow = convert(day);

    $.ajax({
        url: `/Home/ScreeningFilmOfDate`,
        method: "POST",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(saveObj),
        success: function (data) {
            var i = 0;
            $(`#timeshow_${id}`).empty();
            for (i; i < data.timeshows.length; i++) {
                $(`#timeshow_${id}`).append(`<a href="javascript:void(0);" onclick="film.openmodalbookfilm(${data.timeshows[i].showingId})"  class="btn btn-outline-primary ml-5"> ${data.timeshows[i].startTime}</a>`)
            }
        }
    });
}
function convert(str) {
    var date = new Date(str),
        mnth = ("0" + (date.getMonth() + 1)).slice(-2),
        day = ("0" + date.getDate()).slice(-2);
    return [date.getFullYear(), mnth, day].join("-");
}
film.initCategory = function (id) {
    $.ajax({
        url: `/Categoryfilm/Get/${id}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#CategoryFilm').empty();
            $('#CategoryFilm').append(`<p>${data.category.categoryName} </p>`)
        }
    });
}



film.categories = function (cateId) {
    $.ajax({
        url: `/Categoryfilm/Gets`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#CategoryUd').empty();
            $.each(data.categories, function (i, v) {
                var selected = (v.categoryId == cateId) ? "selected" : ""
                $("#CategoryUd").append(`<option value="${v.categoryId}" ${selected}>${v.categoryName}</option>`)
            });
        }
    });
}



film.openmodalbookfilm = function (showingid) {

    $('#bookfilm').modal('show');
}

film.init = function () {
    film.drawFilm();
    film.drawshowing();
};

$(document).ready(function () {
    filmId = $('#FilmId').val();
    film.init();
});