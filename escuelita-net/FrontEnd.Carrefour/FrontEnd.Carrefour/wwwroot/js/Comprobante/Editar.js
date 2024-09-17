$(document).ready(function () {    
    onClickGuardarPostAjax();
});

function irAgregar() {
    window.location.href = '/Comprobante/Editar';
}

function cargarFormulario(data)
{
    $("#IdComprobante").val(data.idComprobante); /*(data.idComprobante) para que el Editar POST guarde los cambios y no quede 0 el id*/
    $("#Comprobante").val(data.comprobante);
    
}

function onClickGuardarPostAjax() {
    $("#btnGuardarPostAjax").on("click", function () {

        var SendInfo = {
            "Comprobante": $("#Comprobante").val(),            
        };
        var obj = { "model": SendInfo };

        $.ajax({
            type: 'post',
            url: '/Comprobante/Agregar',
            data: JSON.stringify(obj),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                console.log(data)
            }
        });
    })
}

