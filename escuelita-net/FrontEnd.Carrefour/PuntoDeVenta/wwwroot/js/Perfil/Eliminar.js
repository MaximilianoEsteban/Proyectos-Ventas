function eliminar()
{
    let marcaId = $("#IdPerfilEliminar").val()
    $.post({
            url: '/Perfil/Eliminar',
            data: marcaId,
            contentType: 'application/json; charset=utf-8'
        })
        .done(function (data) {
            ocultarModalEliminar();
            window.location.reload();
        })
}

function mostrarModalEliminar(IdPerfil)
{
    $("#IdPerfilEliminar").val(IdPerfil);
    $("#eliminarPerfilModal").modal("toggle");
}

function ocultarModalEliminar() {
    $("#eliminarPerfilModal").modal("toggle");
    $("#IdPerfilEliminar").val();
}