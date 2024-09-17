$(document).ready(function () {
    onClickGuardarPostAjax();
});

function irAgregar() {
    window.location.href = '/Producto/Editar';
}


function editarComboMarca(marcaIdActual) {

    $.ajax({
        type: "GET",
        url: "/Marca/ListarMarcasParaCombos",
        dataType: "json",
        contentType: "application/json",
        success: function (data) {
            console.log(data);
            $.each(data, function (i, marca) {

                $('#MarcaId').append('<option value="' + marca.id + '">' + marca.nombreMarca + '</option>');
            });
            $('#MarcaId').val(marcaIdActual);

        },
        error: function (xhr, status, error) {
            alert(xhr.status);
        }
    });

}


function editarComboTipo(tipoIdActual) {
    console.log("inicio editar combo tipo")
    $.ajax({
        type: "GET",
        url: "/Tipo/ListarTiposParaCombos",
        dataType: "json",
        contentType: "application/json",
        success: function (data) {
            console.log(data);
            $.each(data, function (i, tipo) {

                $('#TipoId').append('<option value="' + tipo.id + '">' + tipo.nombre + '</option>');
            });
            $('#TipoId').val(tipoIdActual);
            console.log("fin sucess editar combo tipo")
        },
        error: function (xhr, status, error) {
            alert(xhr.status);
        }
    });
    console.log("fin editar combo tipo")
}

function editarComboUnidad(unidadIdActual) {

    $.ajax({
        type: "GET",
        url: "/Unidad/ListarUnidadesParaCombos",
        dataType: "json",
        contentType: "application/json",
        success: function (data) {
            console.log(data);
            $.each(data, function (i, unidad) {

                $('#UnidadId').append('<option value="' + unidad.id + '">' + unidad.descripcion + '</option>');
            });
            $('#UnidadId').val(unidadIdActual);

        },
        error: function (xhr, status, error) {
            alert(xhr.status);
        }
    });

}

function cargarFormulario(data) {
    console.log(data);
    $("#Nombre").val(data.nombre);
    $("#MarcaId").val(data.marcaId);
    $("#Precio").val(data.precio);
    $("#Stock").val(data.stock);
    $("#TipoId").val(data.tipoId);
    $("#UnidadId").val(data.unidadId);
    $("#Id").val(data.id);
    editarComboTipo(data.tipoId);
    editarComboMarca(data.marcaId);
    editarComboUnidad(data.unidadId);

}



function onClickGuardarPostAjax() {
    $("#btnGuardarPostAjax").on("click", function () {

        var SendInfo = {
            "Nombre": $("#Nombre").val(),
            "MarcaId": $("#MarcaId").val(),
            "Precio": $("#Precio").val(),
            "Stock": $("#Stock").val(),
            "TipoId": $("#TipoId").val(),
            "UnidadId": $("UnidadId").val()
        };
        var obj = { "model": SendInfo };

        $.ajax({
            type: 'post',
            url: '/Producto/Agregar',
            data: JSON.stringify(obj),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                console.log(data)
            }
        });
    })

}



