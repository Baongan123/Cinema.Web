var film = {} || film;
var catId = 0;
film.drawTable = function () {
    $.ajax({
        url: `/Film/Gets/${catId}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#tbFilmOfCategory tbody').empty();
            $.each(data.films, function (i, v) {
                $('#tbFilmOfCategory tbody').append(
                    `<tr>
                        <td>${v.filmId}</td>
                        <td>${v.filmName}</td>
                        <td><img src="${v.image}" alt="" /></td>
                        <td>${v.averageRate}</td>
                        <td>
                            <a href="javascript:;" onclick="film.get(${v.filmId})" class="item"><i class="zmdi zmdi-edit"></i></a>
                            <a href="javascript:;" onclick="film.delete(${v.filmId})" class="item"><i class="zmdi zmdi-delete"></i></a>
                        </td>
                    </tr>`
                );
            });
        }
    });

};

film.openAddEditfilm = function () {
    film.reset();
    $('#addEditFilm').find('.modal-title').text('Add New film');
    film.initCategory();
    $('#addEditFilm').appendTo("body").modal('show');
};




film.uploadImage = function (input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#Image').attr('src', e.target.result);
        };
        reader.readAsDataURL(input.files[0]);
    }
}


film.create = function () {
    var saveObj = {};
    saveObj.FilmName = $('#FilmName').val();
    saveObj.Title = $('#Title').val();
    saveObj.Description = $('#Description').val();
    saveObj.LinkTrailer = $('#Linktrailer').val();
    saveObj.Image = $('#Image').attr('src');
    saveObj.CategoryId = parseInt($('#Category').val());

    $.ajax({
        url: `/Film/Create/`,
        method: "POST",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(saveObj),
        success: function (data) {
            $('#addEditFilm').modal('hide');
            bootbox.alert(data.result.message);
            film.drawTable();
        }
    });
}
film.initCategory = function () {
    $.ajax({
        url: `/Categoryfilm/Get/${catId}`,
        method: "GET",
        dataType: "json",
         success: function (data) {
             $('#Category').empty();
             $('#Category').append(`<option value="${data.category.categoryId}">${data.category.categoryName}</option>`)
        }
    });
}
film.initCategories = function () {
    $.ajax({
        url: `/Categoryfilm/Gets`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#Category').empty();
            $.each(data.categories, function (i, v) {
                $("#Category").append(`<option value=${v.categoryId}>${v.categoryName}</option>`)
            });
        }
    });
}

film.reset = function () {
    $('#FilmName').val("");
    $('#filmId').val("0");
    $('#Title').val("");
    $('#Description').val("");
    $('#Linktrailer').val("");
    $('#Image').attr('src', '/images/noimage.jpg');
    $('#FileUpload').val('');
}
film.init = function () {
    film.drawTable();
};

$(document).ready(function () {
    catId = $('#CategoryId').val();
    film.init();
});