$(document).ready(function () {    
    onClickGuardarPostAjax();
});

function irAgregar() {
    window.location.href = '/Usuario/Editar';
}

function cargarFormulario(data) {
    $("#IdUsuario").val(data.IdUsuario);
    $("#Nombre").val(data.Nombre);
    $("#Apellido").val(data.Apellido);
    $("#Email").val(data.Email);
    $("#Password").val(data.Password);
    $("#IdPerfil").val(data.IdPerfil);
    $("#FechaCreacion").val(data.FechaCreacion);
    $("#FechaPassword").val(data.FechaPassword);
    editarComboPerfil(data.IdPerfil)
}

function editarComboPerfil(IdPerfilActual) {
    $.ajax({
        type: "GET",
        url: "/Perfil/ListarPerfilesParaCombos",
        dataType: "json",
        contentType: "application/json",
        success: function (data) {
            console.log(data);
            $.each(data, function (i, perfil) {
                $('#IdPerfil').append('<option value="' + perfil.IdPerfil + '">' + perfil.Nombre + '</option>');
            });
            $('#IdPerfil').val(IdPerfilActual);            
        },
        error: function (xhr, status, error) {
            alert(xhr.status);
        }
    });

}

function onClickGuardarPostAjax() {
    $("#btnGuardarPostAjax").on("click", function () {

        var SendInfo = {
            "IdUsuario": $("#IdUsuario").val(),
            "Nombre": $("#Nombre").val(),
            "Apellido": $("#Apellido").val(),
            "Email": $("#Email").val(),
            "Password": $("#Password").val(),
            "IdPerfil": $("#IdPerfil").val(),
            "FechaCreacion": $("#FechaCreacion").val(),
            "FechaPassword": $("#FechaPassword").val(),

        };
        var obj = { "model": SendInfo };

        $.ajax({
            type: 'post',
            url: '/Usuario/Agregar',
            data: JSON.stringify(obj),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                console.log(data)
            }
        });
    })
}