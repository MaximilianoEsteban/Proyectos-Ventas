function eliminar()
{
    let subLineaId = $("#subLineaIdEliminar").val()
    $.post({
            url: '/SubLinea/Eliminar',
            data: subLineaId,
            contentType: 'application/json; charset=utf-8'
        })
        .done(function (data) {
            ocultarModalEliminar();
            window.location.reload();
        })
}

function mostrarModalEliminar(subLineaId)
{
    $("#subLineaIdEliminar").val(subLineaId);
    $("#eliminarSubLineaModal").modal("toggle");
}

function ocultarModalEliminar() {
    $("#eliminarSubLineaModal").modal("toggle");
    $("#subLineaIdEliminar").val();
}