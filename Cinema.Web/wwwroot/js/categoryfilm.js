var categoryfilm = {} || categoryfilm;

categoryfilm.drawTable = function () {
    $.ajax({
        url: "/CategoryFilm/Gets",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#tbCategoryFilm tbody').empty();
            $.each(data.categories, function (i, v) {
                $('#tbCategoryFilm tbody').append(
                    `<tr>
                        <td>${v.categoryId}</td>
                        <td>${v.categoryName}</td>
                        <td><a href="/Film/FilmOfCategory/${v.categoryId}" >${v.count}</a></td>
                    </tr>`
                );
            });
        }
    });

}; 
categoryfilm.drawListCategoryfilm = function () {
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
categoryfilm.init = function () {
    categoryfilm.drawListCategoryfilm();
    categoryfilm.drawTable();
};

$(document).ready(function () {
    categoryfilm.init();
});