$(document).ready(function () {
    $('#myTable').DataTable({
        "ajax": {
            "url": '/admin/category/getall',
            "type": "GET",

        },


        'columns': [
            { "data": 'name', "width": "25%" },
            { "data": 'displayOrder', "width": "25%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                             <a href="/admin/category/edit?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                             <a href="/admin/category/delete?id=${data}" class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                            </div>`
                },
                "width": "25%"
            }


        ]
    });
    console.log("success");
});