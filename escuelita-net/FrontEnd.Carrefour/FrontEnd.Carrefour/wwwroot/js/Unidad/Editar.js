$(document).ready(function () {
    onClickGuardarPostAjax();

});

function irAgregar() {
    window.location.href = '/Unidad/Editar';
}

function cargarFormulario(data) {

    $("#Id").val(data.id);
    $("#Descripcion").val(data.descripcion);

}

function onClickGuardarPostAjax() {
    $("#btnGuardarPostAjax").on("click", function () {

        var SendInfo = {
            "descripcion": $("#descripcion").val(),

        };
        var obj = { "model": SendInfo };

        $.ajax({
            type: 'post',
            url: '/Unidad/Agregar',
            data: JSON.stringify(obj),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                console.log(data)
            }
        });
    })
}
