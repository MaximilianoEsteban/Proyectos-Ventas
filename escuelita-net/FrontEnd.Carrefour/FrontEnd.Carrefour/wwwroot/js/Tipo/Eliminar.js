function eliminar() {
    let tipoId = $("#tipoIdEliminar").val()
    $.post({
        url: '/Tipo/Eliminar',
        data: tipoId,
        contentType: 'application/json; charset=utf-8'
    })
        .done(function (data) {
            ocultarModalEliminar();
            window.location.reload();
        })
}

function mostrarModalEliminar(tipoId) {
    $("#tipoIdEliminar").val(tipoId);
    $("#eliminarTipoModal").modal("toggle");
}

function ocultarModalEliminar() {
    $("#eliminarTipoModal").modal("toggle");
    $("#tipoIdEliminar").val();
}