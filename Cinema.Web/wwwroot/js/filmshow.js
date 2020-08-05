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
film.get = function () {
    $.ajax({
        url: `/Film/Get/${filmId}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#ImageUd').attr('src', data.film.image);
            $('#FilmNameUd').val(data.film.filmName);
            $('#TitleUd').val(data.film.title);
            $('#DescriptionUd').val(data.film.description);
            $('#LinktrailerUd').val(data.film.linkTrailer);
            film.categories(data.film.categoryId)
            $('#addEditFilm').appendTo("body").modal('show');

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



film.categories = function (cateId) {
    $.ajax({
        url: `/Categoryfilm/Gets`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#CategoryUd').empty();
            $.each(data.categories, function (i, v) {
                var selected = (v.categoryId == cateId)? "selected" : ""
                $("#CategoryUd").append(`<option value="${v.categoryId}" ${selected}>${v.categoryName}</option>`)
            });
        }
    });
}
film.update = function () {
    var saveObj = {};
    saveObj.FilmId = parseInt(filmId);
    saveObj.FilmName = $('#FilmNameUd').val();
    saveObj.Title = $('#TitleUd').val();
    saveObj.Description = $('#DescriptionUd').val();
    saveObj.LinkTrailer = $('#LinktrailerUd').val();
    saveObj.Image = $('#ImageUd').attr('src');
    saveObj.CategoryId = parseInt($('#CategoryUd').val());

    $.ajax({
        url: `/Film/Update/`,
        method: "POST",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(saveObj),
        success: function (data) {
            $('#addEditFilm').modal('hide');
            bootbox.alert(data.result.message);
            film.drawFilm();
        }
    });

}
film.uploadImage = function (input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#ImageUd').attr('src', e.target.result);
        };
        reader.readAsDataURL(input.files[0]);
    }
}

film.init = function () {
    film.drawFilm();
};

$(document).ready(function () {
    filmId = $('#FilmId').val();
    film.init();
});