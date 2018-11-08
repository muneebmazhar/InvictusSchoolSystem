
$(document).ready(function () {
    clearform();
});


function clearform() {
    $('#C_Name').val('');
    $('#Fees').val('');
   


}

function AddClass() {
    debugger;
    //preventDefault();

    var Cl_Name = $('#C_Name').val();
    var C_Fees = $('#Fees').val();
   

    if (Cl_Name == "") {
        ShowError("Please Enter Class Name");
        return;
    }
    if (C_Fees == "") {
        ShowError("Please Enter Fees");
        return;
    }
    

    $.ajax({
        url: "/Class/AddClass",
        type: "Post",

        data: {
            Name: Cl_Name,
            Fees: C_Fees,
            

        },
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        datatype: "json",
        success: function (data) {
            if (data.msg == "save") {
                ShowSuccess('Save SuccessFully');
                clearform();
            }
        },
        error: function (error) {
            ShowError('Error in saving');
        },

    });
}