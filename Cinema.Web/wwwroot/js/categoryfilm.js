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
categoryfilm.init = function () {
    categoryfilm.drawTable();
};

$(document).ready(function () {
    categoryfilm.init();
});