$(document).ready(function () {
    $("#btnSave").click(function () {
        if ($("#Name").val() == "") {
            alert("Enter Name");
            return false;
        }
        if ($("#Password").val() == "") {
            alert("Enter password");
            return false;
        }
        if ($("#Email").val() == "") {
            alert("Enter Email");
            return false;
        }
        if ($("#Phone").val() == "") {
            alert("Enter Phone");
            return false;
        }
        if ($("#Address1").val() == "") {
            alert("Enter Address1");
            return false;
        }
        var data = $("#frmNewUser").serialize();

        $.ajax({
            type: "post",
            data: data,
            url: "Login/NewUser",
            success: function (response) {
                if (response == "Saved") {
                    alert("Data saved successfully");
                    window.location.href="Display";
                }
                else {
                    alert("Not saved");
                    return false;
                }
            }
        })
    })
})