function eliminar()
{
    let productoId = $("#productoIdEliminar").val()
    $.post({
            url: '/Producto/Eliminar',
            data: productoId,
            contentType: 'application/json; charset=utf-8'
        })
        .done(function (data) {
            ocultarModalEliminar();
            window.location.reload();
        })
}

function mostrarModalEliminar(productoId)
{
    $("#productoIdEliminar").val(productoId);
    $("#eliminarProductoModal").modal("toggle");
}

function ocultarModalEliminar() {
    $("#eliminarProductoModal").modal("toggle");
    $("#productoIdEliminar").val();
}