$(document).ready(function () {
    onClickGuardarPostAjax();

});

function irAgregar() {
    window.location.href = '/Perfil/Editar';
}

function cargarFormulario(data) {
    console.log("documentreadyeditarJS");

    console.log(data);
    $("#IdPerfil").val(data.IdPerfil);
    $("#Nombre").val(data.Nombre);
}

function onClickGuardarPostAjax() {
    $("#btnGuardarPostAjax").on("click", function () {

        var SendInfo = {
            "Nombre": $("#Nombre").val(),
            "IdPerfil": $("#IdPerfil").val()
        };
        var obj = { "model": SendInfo };

        $.ajax({
            type: 'post',
            url: '/Perfil/Editar',
            data: JSON.stringify(obj),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                console.log(data)
            }
        });
    })
}

