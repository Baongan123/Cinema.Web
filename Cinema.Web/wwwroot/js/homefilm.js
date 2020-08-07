var film = {} || film;
var filmId = 0;
var link = `https://www.youtube.com/embed`;
<<<<<<< HEAD
var rowseat = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J"]
var arrSeat = [];
var numberChairOn = 0;
var dayshow = "";
var starttime = "";
var roomname = "";
var priceticket = 0;
var arrOrder = [];
var arrNumberOrder = [];
var saveshowingId = 0;
var totalpriceTicket = 0;
var totalpriceOrder = 0;
var totalprice1Order = 0;
=======
>>>>>>> a52cde792d7304556d4ee4e2271c07b457baaed5

film.drawFilm = function () {
    $.ajax({
        url: `/Film/Get/${filmId}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#Image').attr('src', data.film.image);
            $('#FilmName').empty()
            $('#FilmName').append(`<p>${data.film.filmName} </p>`);
            $('#FilmNameBK').empty()
            $('#FilmNameBK').append(`<p>${data.film.filmName} </p>`);
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
film.showing = function (day, id) {
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
                $(`#timeshow_${id}`).append(`<a href="javascript:void(0);" 
                                onclick="film.openmodalbookfilm(${data.timeshows[i].showingId})" 
                                class="btn btn-outline-primary ml-5"> ${data.timeshows[i].startTime}</a>`)
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

film.resetallvalue = function () {
    arrSeat = [];
    arrOrder = [];
    arrOrder = [];
    arrNumberOrder = [];
    totalpriceTicket = 0;
    totalpriceOrder = 0;
    $("#totalprice").empty();
    $("#desBookTicket").empty();
    $("#desBookOrder").empty();
    $(`#nextFood`).removeClass("textCustom");
    $("#buttonNext").empty();
    $(`#nextXN`).removeClass("textCustom");
}

film.openmodalbookfilm = function (showingid) {
<<<<<<< HEAD
    film.resetallvalue();
    film.descriptionshowing(showingid);
    $.ajax({
        url: `/showing/seats/${showingid}`,
        method: "get",
        datatype: "json",
        success: function (data) {
            saveshowingId = showingid;
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

film.descriptionshowing = function (id) {
    $.ajax({
        url: `/Showing/DescriptionShowing/${id}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            starttime = data.descriptionShowing.startTime;
            dayshow = data.descriptionShowing.dayshow;
            roomname = data.descriptionShowing.roomName;
            numberChairOn = data.descriptionShowing.numberChairOn;
            priceticket = data.descriptionShowing.priceTicket;
            $('#timeshowoffilm').empty()
            $('#timeshowoffilm').append(`<p>${starttime}     ${dayshow} </p>`);
            $('#priceticket').empty()
            $('#priceticket').append(`<p>${priceticket} VNĐ</p>`);
        }
    });
}

film.bookchair = function (seatid) {
    var seat = `seat${seatid}`;
    var idhiddenseat = `#val_seat${seatid}`;
    var seathidden = parseInt($(idhiddenseat).val());
    if (seathidden % 2 == 0) {
        document.getElementById(seat).classList.add("custonbutton");
        arrSeat.push(seatid);
        // console.log(arrSeat);
    } else {
        $(`#${seat}`).removeClass("custonbutton");
        arrSeat.remove(seatid);
        // console.log(arrSeat);
    }
    $(idhiddenseat).val(seathidden + 1);
    if (arrSeat.length > 0) {
        film.addButtonNextCheckSeat();
    } else {
        $("#buttonNext").empty();
    }
    totalpriceTicket = arrSeat.length * priceticket;
    $("#desBookTicket").empty();
    $("#desBookTicket").append(`
         <div class="col-7">
                <h6>Vé xem phim </h6>
         </div>
        <div class="col-2 text-center">
            <h6>${arrSeat.length}</h6>
        </div>
        <div class="col-3 text-center">
            <h6>${arrSeat.length * priceticket}</h6>
        </div>
    `);

}

film.bookOrder = function () {
    $("#addbookbody").empty();
    document.getElementById("nextFood").classList.add("textCustom");
    $.ajax({
        url: `/ComboFood/Gets`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $.each(data.comboFoods, function (i, v) {
                $("#addbookbody").append(
                    `   <div class="col-4 p-2 border-2">
                        
                        <img style="width:100%;height:100px" src="${v.imageCombo}" />
                           <div> <h6>${v.comboName}</h6> </div>
                                    <div class="row">
                                        <div class="col-6">
                                            <h6>${v.price} </h6>
                                        </div>
                                        <div class="col-6 text-rigth">
                                            <input min=0 type="number" value=0 id="countcb${v.comboFoodId}"
                                                    style="width:50px" oninput="film.addOrder(${v.comboFoodId})" />
                                        </div>
                                    </div>
                            </div>               
                                   
                `
                )
            });

        }
    });
    film.addButtonNextCheckFood();
}

film.nextconfirm = function () {
    $("#addbookbody").empty();
    document.getElementById("nextXN").classList.add("textCustom");
    film.addButtonNextComfirm();

=======

    $('#bookfilm').modal('show');
>>>>>>> a52cde792d7304556d4ee4e2271c07b457baaed5
}

film.addOrder = function (id) {
    var count = parseInt($(`#countcb${id}`).val());
    var index = arrOrder.indexOf(id);
    if (count > 0) {
        if (index != -1) {
            arrNumberOrder[index] = count;
        } else {
            arrNumberOrder.push(count);
            arrOrder.push(id);
        }
    }
    else {
        if (index != -1) {
            arrOrder.remove(id);
            arrNumberOrder.remove(arrNumberOrder[index]);
        }
    }

    totalpriceOrder = 0;
    $("#desBookOrder").empty();
    if (arrOrder.length > 0) {
        for (var j = 0; j < arrOrder.length; j++) {
            film.drawComboOrder(j);
        }
    }
    console.log(arrOrder);
    console.log(arrNumberOrder);

}

film.drawComboOrder = function (j) {
    var cbId = arrOrder[j];
    $.ajax({
        url: `/ComboFood/Get/${cbId}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            var sl = arrNumberOrder[j];
            var gia = data.comboFood.price;
            var tong = sl * gia;
            console.log(tong);
            totalpriceOrder = totalpriceOrder + tong;
            console.log("total= " + totalpriceOrder);
            $("#desBookOrder").append(`
                          <div class="col-7">
                                <h6>${data.comboFood.comboName}</h6>
                         </div>
                        <div class="col-2 text-center">
                            <h6>${sl}</h6>
                        </div>
                        <div class="col-3 text-center">
                             <input hidden value="${sl * gia}" id="price${j}"/>
                            <h6>${sl * gia}</h6>
                        </div>
             `);
        }
    });
}
film.totalprice = function () {
    if (arrOrder.length > 0) {
        for (var i = 0; i < arrOrder.length; i++) {
            var pp = parseInt($(`#price${i}`).val());
            totalpriceOrder = totalpriceOrder + pp;
        }
    }
    console.log(totalpriceOrder);
}
film.addButtonNextCheckSeat = function () {
    $("#buttonNext").empty();
    $("#buttonNext").append(`<input class="btn btn-success" style="width:100px;height:30px" 
                type='button' value="Tiếp theo" onclick='film.bookOrder()'>`)
}
film.addButtonNextCheckFood = function () {
    $("#buttonNext").empty();
    $("#buttonNext").append(`<input class="btn btn-success" style="width:100px;height:30px" 
                type='button' value="Tiếp theo" onclick='film.totalprice()'>`)
}
film.addButtonNextComfirm = function () {
    $("#buttonNext").empty();
    $("#buttonNext").append(`<input class="btn btn-success" style="width:100px;height:30px" 
                type='button' value="Tiếp theo" onclick='film.totalprice()'>`)
}
Array.prototype.remove = function () {
    var what, a = arguments, L = a.length, ax;
    while (L && this.length) {
        what = a[--L];
        while ((ax = this.indexOf(what)) !== -1) {
            this.splice(ax, 1);
        }
    }
    return this;
};

film.init = function () {
    film.drawFilm();
    film.drawshowing();
};

$(document).ready(function () {
    filmId = $('#FilmId').val();
    film.init();
});