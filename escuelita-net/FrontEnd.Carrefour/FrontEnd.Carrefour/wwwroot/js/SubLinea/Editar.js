$(document).ready(function () {    
    onClickGuardarPostAjax();
});

function irAgregar() {
    window.location.href = '/SubLinea/Editar';
}

function cargarFormulario(data) {
    $("#Id").val(data.id);    
    $("#LineaId").val(data.lineaId);
    $("#Nombre").val(data.nombre);
    editarComboLinea(data.lineaId)
}

function editarComboLinea(lineaIdActual) {
    $.ajax({
        type: "GET",
        url: "/Linea/ListarLineasParaCombos",
        dataType: "json",
        contentType: "application/json",
        success: function (data) {
            console.log(data);
            $.each(data, function (i, linea) {
                $('#LineaId').append('<option value="' + linea.id + '">' + linea.descripcion + '</option>');
            });
            $('#LineaId').val(lineaIdActual);            
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
            "LineaId": $("#LineaId").val(),

        };
        var obj = { "model": SendInfo };

        $.ajax({
            type: 'post',
            url: '/SubLinea/Agregar',
            data: JSON.stringify(obj),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                console.log(data)
            }
        });
    })
}