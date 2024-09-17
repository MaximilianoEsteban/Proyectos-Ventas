function eliminar()
{
    let marcaId = $("#marcaIdEliminar").val()
    $.post({
            url: '/Marca/Eliminar',
            data: marcaId,
            contentType: 'application/json; charset=utf-8'
        })
        .done(function (data) {
            ocultarModalEliminar();
            window.location.reload();
        })
}

function mostrarModalEliminar(productoId)
{
    $("#marcaIdEliminar").val(productoId);
    $("#eliminarMarcaModal").modal("toggle");
}

function ocultarModalEliminar() {
    $("#eliminarMarcaModal").modal("toggle");
    $("#marcaIdEliminar").val();
}