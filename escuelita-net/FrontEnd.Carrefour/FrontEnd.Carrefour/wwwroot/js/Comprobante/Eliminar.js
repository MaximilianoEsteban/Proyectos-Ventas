function eliminar() {
    let IdComprobante = $("#IdComprobanteEliminar").val()
    $.post({
        url: '/Comprobante/Eliminar',
        data: IdComprobante,
        contentType: 'application/json; charset=utf-8'
    })
        .done(function (data) {
            ocultarModalEliminar();
            window.location.reload();
        })
}

function mostrarModalEliminar(IdComprobante) {
    $("#IdComprobanteEliminar").val(IdComprobante);
    $("#eliminarComprobanteModal").modal("toggle");
}

function ocultarModalEliminar() {
    $("#eliminarComprobanteModal").modal("toggle");
    $("#IdComprobanteEliminar").val();
}