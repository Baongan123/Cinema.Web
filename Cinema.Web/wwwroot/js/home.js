var home = {} || home;

//home.drawTable = function () {
//    $.ajax({
//        url: "/Home/Gets",
//        method: "GET",
//        dataType: "json",
//        success: function (data) {
//            $('#homefilm').empty();
//            $.each(data.films, function (i, v) {
//                $('#homefilm').append(
//                    `
//                  <div class="col-md-6 col-lg-3 mb-5 mb-lg-5 ">
//                                <div class="ftco-media-1">
//                                    <div class="ftco-media-1-inner">
//                                        <a href="property-single.html" class="d-inline-block mb-4"><img src="${v.image}" alt="${v.filmName}" class="img-fluid"></a>
//                                        <div class="ftco-media-details">
//                                            <h3>${v.filmName}</h3>
//                                            <p>${v.title}</p>
//                                        </div>

//                                    </div>
//                                </div>
//                    </div>`
//                );
//            });
//        }
//    });

//};
home.deleteshowingbytime = function () {
    $.ajax({
        url: `/Showing/DeleteByTime`,
        method: "GET",
        dataType: "json",
        success: function (data) {
        }
    });
}
home.init = function () {
    home.deleteshowingbytime();
};

$(document).ready(function () {
    home.init();
});