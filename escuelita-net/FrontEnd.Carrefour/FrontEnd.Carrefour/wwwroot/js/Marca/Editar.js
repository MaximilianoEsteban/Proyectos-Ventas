$(document).ready(function () {
    onClickGuardarPostAjax();

});

function irAgregar() {
    window.location.href = '/Marca/Editar';
}

function cargarFormulario(data) {
    console.log("documentreadyeditarJS");

    console.log(data);
    $("#Id").val(data.id);
    $("#nombreMarca").val(data.nombreMarca);

}



function onClickGuardarPostAjax() {
    $("#btnGuardarPostAjax").on("click", function () {

        var SendInfo = {
            "nombreMarca": $("#nombreMarca").val(),
            "Id": $("#Id").val()
        };
        var obj = { "model": SendInfo };

        $.ajax({
            type: 'post',
            url: '/Marca/Editar',
            data: JSON.stringify(obj),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                console.log(data)
            }
        });
    })
}

