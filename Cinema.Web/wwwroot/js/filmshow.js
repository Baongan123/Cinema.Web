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
            $('#Description').empty()
            $('#Description').append(`<p>${data.film.description} </p>`)
            $('#action2').empty();
            $('#action2').append(`<h3>${data.film.filmName}</h3>`)
            $('#trailer').attr('src', `${link}/${data.film.linkTrailer}`);
            film.initCategory(data.film.categoryId);

        }
    });
}

film.initCategory = function (id) {
    $.ajax({
        url: `/Categoryfilm/Get/${id}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#action1').empty();
            $('#action1').append(`<a href="/Film/FilmOfCategory/${data.category.categoryId}"><h3>${data.category.categoryName}</h3></a>`)


            $('#CategoryFilm').empty();
            $('#CategoryFilm').append(`<p>${data.category.categoryName} </p>`)
        }
    });
}
film.drawListCategoryfilm = function () {
    $.ajax({
        url: `/Categoryfilm/Gets`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#listcategoryfilm').empty();
            $.each(data.categories, function (i, v) {
                $("#listcategoryfilm").append(`<li><a href="/Film/FilmOfCategory/${v.categoryId}">${v.categoryName}</a></li>`)
            });
        }
    });
}

film.init = function () {
    film.drawListCategoryfilm();
    film.drawFilm();
};

$(document).ready(function () {
    filmId = $('#FilmId').val();
    film.init();
});