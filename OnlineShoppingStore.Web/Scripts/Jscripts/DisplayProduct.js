$(document).ready(function () {
    $("#btnSave").click(function () {
        var data = $("#frmAddUpdateProduct").serialize();
        alert(data);
        if ($("#ProductName").val() == "") {
            alert("Enter Product name");
            return false;
        }

        $.ajax({
            type: "post",
            url: "AddUpdateProduct",
            data: data,
            success: function (response) {
                if (response == "True") {
                    alert("Data saved");
                    window.location.href = "DisplayProducts";
                }
            }
        })
    })
})
function fnDelete(ProductId) {
    var result = confirm("Are you sure to delete");
    if (result) {
        $.ajax({
            type: "post",
            url: "DeleteProduct",
            data: "ProductId" + ProductId,
            success: function (response) {
                if (response == "True") {
                    alert("Data deleted");
                    window.location.href = "DisplayProducts";
                }
            }
        })
    }
}