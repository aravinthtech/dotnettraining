function insertEmployee() {

    var employee = {
        FirstName: $("#FirstName").val(),
        LastName: $("#LastName").val(),
        Email: $("#Email").val()
    }
    $.ajax({
        url: "/Home/Submit",
        method: "POST",
        data: JSON.stringify(employee),
        dataType: "json",
        contentType: 'application/json',
        success: function (response) {
            alert("Employee inserted successfully");
        },
        error: function (error) {

        }

    })
}