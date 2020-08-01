var categoryfilm = {} || categoryfilm;

categoryfilm.drawTable = function () {
    $.ajax({
        url: "/Home/Gets",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#tbDepart tbody').empty();
            $.each(data.categories, function (i, v) {
                $('#tbDepart tbody').append(
                    `<tr>
                        <td>${v.categoryId}</td>
                        <td>${v.categoryName}</td>
                        <td>${v.count}</td>
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