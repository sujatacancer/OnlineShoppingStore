
$(document).ready(function () {
    $('#tblCateogry').dataTable({
        columnDefs: [
            { orderable: false, targets: -1 }
        ]
    });


});


function fnDelete(categoryId) {

    var result = confirm("Are you sure to delete");
    if (result == true) {

        $.ajax({
            type: "post",
            url: "DeleteCateogry",
            data: "CategoryId=" + categoryId,
            success: function (response) {
                if (response == "True") {
                    alert("Data deleted");
                    window.location.href = "LoadCategory";
                }
            }
        })
    }
}