$(document).ready(function () {    
    onClickGuardarPostAjax();
});

function irAgregar() {
    window.location.href = '/Tipo/Editar';
}

function cargarFormulario(data) {
    $("#Id").val(data.id);
    $("#SubLineaId").val(data.subLineaId);
    $("#Nombre").val(data.nombre);
    editarComboSubLinea(data.subLineaId)

}

function editarComboSubLinea(subLineaIdActual) {
    $.ajax({
        type: "GET",
        url: "/SubLinea/ListarSubLineasParaCombos",
        dataType: "json",
        contentType: "application/json",
        success: function (data) {
            console.log(data);
            $.each(data, function (i, subLinea) {

                $('#SubLineaId').append('<option value="' + subLinea.id + '">' + subLinea.nombre + '</option>');
            });
            $('#SubLineaId').val(subLineaIdActual);
        },
        error: function (xhr, status, error) {
            alert(xhr.status);
        }
    });

}

function onClickGuardarPostAjax() {
    $("#btnGuardarPostAjax").on("click", function () {

        var SendInfo = {
            "Nombre": $("#Nombre").val(),
            "SubLineaId": $("#SubLineaId").val(),
        };
        var obj = { "model": SendInfo };

        $.ajax({
            type: 'post',
            url: '/Tipo/Agregar',
            data: JSON.stringify(obj),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                console.log(data)
            }
        });
    })
}
