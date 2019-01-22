$(document).ready(function () {
    $("#btnLogin").click(function () {
        if ($("#Name").val() == "") {
            alert("Enter Name");
            return false;
        }
        if ($("#Password").val() == "") {
            alert("Enter Password");
            return false;
        }
        var data = $("#loginForm").serialize();
        $.ajax({
            type: "post",
            url:"Login/CheckLogin",
            data:data,
            success: function (response) {
                if (response == "True") {
                    window.location.href("Home/Main")
                }
                else {
                    alert("User Name or password is not correct");
                }
            }
        })
    })
})