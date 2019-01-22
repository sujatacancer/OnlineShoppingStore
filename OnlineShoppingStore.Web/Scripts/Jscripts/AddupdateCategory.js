
$(document).ready(function () {
    $("#btnSave").click(function () {
        var data = $("#frmCategory").serialize();
        alert(data);
        if ($("#CategoryName").val() == "") {
            alert("Enter category name");
            return false;
        }

        $.ajax({
            type: "post",
            url: "AddUpdateCateogry",
            data: data,
            success: function (response) {
                if (response == "True") {
                    alert("Data saved");
                    window.location.href = "LoadCategory";
                }
            }
        })
    })
})