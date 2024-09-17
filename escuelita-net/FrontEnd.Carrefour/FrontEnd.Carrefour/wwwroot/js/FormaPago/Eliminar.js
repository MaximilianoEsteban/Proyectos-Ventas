function eliminar() {
    let IdFormaPago = $("#IdFormaPagoEliminar").val()
    $.post({
        url: '/FormaPago/Eliminar',
        data: IdFormaPago,
        contentType: 'application/json; charset=utf-8'
    })
        .done(function (data) {
            ocultarModalEliminar();
            window.location.reload();
        })
}

function mostrarModalEliminar(IdFormaPago) {
    $("#IdFormaPagoEliminar").val(IdFormaPago);
    $("#eliminarFormaPagoModal").modal("toggle");
}

function ocultarModalEliminar() {
    $("#eliminarFormaPagoModal").modal("toggle");
    $("#IdFormaPagoEliminar").val();
}