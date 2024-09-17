function eliminar() {
    let lineaId = $("#lineaIdEliminar").val()
    $.post({
        url: '/Linea/Eliminar',
        data: lineaId,
        contentType: 'application/json; charset=utf-8'
    })
        .done(function (data) {
            ocultarModalEliminar();
            window.location.reload();
        })
}

function mostrarModalEliminar(lineaId) {
    $("#lineaIdEliminar").val(lineaId);
    $("#eliminarLineaModal").modal("toggle");
}

function ocultarModalEliminar() {
    $("#eliminarLineaModal").modal("toggle");
    $("#lineaIdEliminar").val();
}