var film = {} || film;
var catId = 0;
//film.drawTable = function () {
//    $.ajax({
//        url: `/film/Gets/${catId}`,
//        method: "GET",
//        dataType: "json",
//        success: function (data) {
//            $('#tbfilm tbody').empty();
//            $.each(data.films, function (i, v) {
//                $('#tbfilm tbody').append(
//                    `
//                    <tr>
//                        <td>${v.filmId}</td>
//                        <td>${v.filmName}</td>
//                        <td>${v.price}</td>
//                        <td><img src='${v.image}' width='80' height='90'/></td>
//                        <td>
//                            <a href="javascript:;" onclick="film.get(${v.filmId})" class="item"><i class="zmdi zmdi-edit"></i></a>
//                            <a href="javascript:;" onclick="film.delete(${v.filmId})" class="item"><i class="zmdi zmdi-delete"></i></a>
//                        </td>
//                    </tr>
//                    `
//                );
//            });
//        }
//    });
//};
film.openAddEditfilm = function () {
    film.reset();
    film.initCategories();
    $('#addEditFilm').appendTo("body").modal('show');
};
//film.delete = function (id) {
//    bootbox.confirm({
//        title: "Delete department?",
//        message: "Do you want to delete this film.",
//        buttons: {
//            cancel: {
//                label: '<i class="fa fa-times"></i> No'
//            },
//            confirm: {
//                label: '<i class="fa fa-check"></i> Yes'
//            }
//        },
//        callback: function (result) {
//            if (result) {
//                $.ajax({
//                    url: `/film/Delete/${id}`,
//                    method: "GET",
//                    dataType: "json",
//                    success: function (data) {
//                        bootbox.alert(data.result.message);
//                        film.drawTable();
//                    }
//                });
//            }
//        }
//    });
//}
film.uploadImage = function (input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#Image').attr('src', e.target.result);
        };
        reader.readAsDataURL(input.files[0]);
    }
}

film.reset = function () {
    $('#FilmName').val("");
    $('#FilmId').val(0);
    $('#Title').val("");
    $('#Description').val(catId);
    $('#Category').val(catId);
    $('#Image').attr('src', '/images/noimage.jpg');
    $('#FileUpload').val('');
    $('#addEditfilm').find('.modal-title').text('Add New film');
}
film.create = function () {
    var saveObj = {};
    saveObj.FilmName = $('#FilmName').val();
    saveObj.Description = $('#Description').val();
    saveObj.Title = $('#Title').val();
    saveObj.Image = $('#Image').attr('src');
    saveObj.LinkTrailer = $('#LinkTrailer').val()
    saveObj.CategoryId = parseInt($('#Category').val());
    $.ajax({
        url: `/Home/CreateFilm/`,
        method: "POST",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(saveObj),
        success: function (data) {
            $('#addEditFilm').modal('hide');
            bootbox.alert(data.result.message);
            home.drawTable ();
        }
    });
}

film.initCategories = function () {
    $.ajax({
        url: `/CategoryFilm/Gets`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#Department').empty();
            $.each(data.categories, function (i, v) {
                $("#Category").append(`<option value=${v.categoryId}>${v.categoryName}</option>`)
            });
        }
    });
}
film.init = function () {
    film.drawTable();
    film.initCategory();
};
$(document).ready(function () {
    catId = $('#CategoryId').val();
    film.init();
});