var film = {} || film;
var filmId = 0;
var link = `https://www.youtube.com/embed`;
var rowseat=["A","B","C","D","E","F","G","H","I","J"]

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
    $.ajax({
        url: `/showing/seats/${showingid}`,
        method: "get",
        datatype: "json",
        success: function (data) {
            $('#addbookbody').empty();
            $("#addbookbody").append(
                `
                     <table id="bookseat">
                        <tr>
                            <th colspan="1"></th>
                            <th colspan="10" style="border:2px solid;text-align:center"><h3>Màn hình</h3></th>
                        </tr>
                        <tr id="numberseat">
                            <th width = "50" height = "30" ></th >
                        </tr>
                      
                   </table >
                `
            )
            for (var i = 0; i < 10; i++) {
                $("#numberseat").append(`<th width = "50" height = "30" style="text-align:center">${i + 1}</th >`)
                $("#addbookbody").append(`
                         <tr id="rowseat${i}">
                            <th width = "50" height = "30" style="text-align:center">${rowseat[i]}</th>
                        </tr>
                `)
                for (var j = 0; j <= 9; j++) {
                    var index = i * 10 + j;
                    if (data.seats[index].status == 'false') {
                        $(`#rowseat${i}`).append(`<td width = "50" height = "30" style="text-align:center">
                                 <input hidden id='val_seat${data.seats[index].seatId}' value="0" />
                               <input class="" style="width:30px;height:30px" type='button' id='seat${data.seats[index].seatId}' 
                                        onclick='film.bookchair(${data.seats[index].seatId})'>
                            </td>`)
                    } else {
                        $(`#rowseat${i}`).append(`<td width = "50" height = "30" style="text-align:center">
                                <input type='button' style="width:30px;height:30px;background-color:red" value=''>
                            </td>`)
                    }
                }
            }
        }
    });
    $('#bookfilm').modal('show');
}

film.bookchair = function (seatid) {
    var seat = `seat${seatid}`;
    var idhiddenseat = `#val_seat${seatid}`;
    var seathidden = parseInt($(idhiddenseat).val());
    if (seathidden % 2 == 0) {
        document.getElementById(seat).classList.add("custonbutton");
    } else {
        $(`#${seat}`).removeClass("custonbutton");
    }
    $(idhiddenseat).val(seathidden + 1);
}

film.init = function () {
    film.drawFilm();
    film.drawshowing();
};

$(document).ready(function () {
    filmId = $('#FilmId').val();
    film.init();
});