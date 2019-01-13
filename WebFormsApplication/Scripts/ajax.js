$(function () {
    $('#btnSend').click(function () {

        var frstName = $("#txtFirstName").val();
        var lstName = $("#txtLastName").val();

        var parameters = {FirstName: frstName, LastName: lstName};

        $.ajax({
            type: "POST",
            url: 'CustomerService.asmx/GetCustomer',
            contentType: 'application/json; charset=utf-8',
            data: JSON.stringify({ customer: parameters }),
            dataType: 'json',
            success: function (data, status, xhr) {
                $("#myDiv").html("Inserted user ID: <b>" + data.d.ID + "</b> FirstName: <b>" + data.d.FirstName + "</b> LastaName: <b>" + data.d.LastName + "</b> Date: <b>" + data.d.CreationTime + "</b>");
            },
            error: function (xhr, status, error) {
                $("#myDiv").html('error occured: ' + status);
            }
        });
    });
});