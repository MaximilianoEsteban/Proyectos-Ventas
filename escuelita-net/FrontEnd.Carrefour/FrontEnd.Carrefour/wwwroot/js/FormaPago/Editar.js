$(document).ready(function () {
    onClickGuardarPostAjax();
});

function irAgregar() {
    window.location.href = '/FormaPago/Editar';
}

function cargarFormulario(data) {
    $("#IdFormaPago").val(data.idFormaPago); /*(data.idFormaPago) para que el Editar POST guarde los cambios y no quede 0 el id*/
    $("#FormaPago").val(data.formaPago);
}

function onClickGuardarPostAjax() {
    $("#btnGuardarPostAjax").on("click", function () {

        var SendInfo = {
            "FormaPago": $("#FormaPago").val(),
        };
        var obj = { "model": SendInfo };

        $.ajax({
            type: 'post',
            url: '/FormaPago/Agregar',
            data: JSON.stringify(obj),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                console.log(data)
            }
        });
    })
}


