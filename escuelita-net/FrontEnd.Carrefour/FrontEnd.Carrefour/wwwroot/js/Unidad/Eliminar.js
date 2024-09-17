function eliminar() {
    let unidadId = $("#unidadIdEliminar").val()
    $.post({
        url: '/Unidad/Eliminar',
        data: unidadId,
        contentType: 'application/json; charset=utf-8'
    })
        .done(function (data) {
            ocultarModalEliminar();
            window.location.reload();
        })
}

function mostrarModalEliminar(unidadId) {
    $("#unidadIdEliminar").val(unidadId);
    $("#eliminarUnidadModal").modal("toggle");
}

function ocultarModalEliminar() {
    $("#eliminarUnidadModal").modal("toggle");
    $("#unidadIdEliminar").val();
}