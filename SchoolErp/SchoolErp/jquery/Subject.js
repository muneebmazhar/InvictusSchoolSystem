﻿
$(document).ready(function () {
    clearform();
});


function clearform() {
    $('#S_Name').val('');

    $("#S_Class").val('');
    $('#S_Class').trigger('change');
   



}

function AddSection() {
    debugger;
    //preventDefault();

    var name = $('#S_Name').val();


    var cl = $('#S_Class option:selected').val();
   


    if (name == "") {
        ShowError("Please Enter  Name");
        return;
    }
    if (cl == "") {
        ShowError("Please Enter Class");
        return;
    }
   



    $.ajax({
        url: "/Class/AddSubject",
        type: "Post",

        data: {
            Name: name,
            Class_Id: cl,
           
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