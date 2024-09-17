$(document).ready(function () {
    llenarComboMarca();
    llenarComboTipo();
    onClickGuardarPostAjax();
    llenarComboUnidad();

    const validation = new JustValidate('form');

    validation
        .addField('#Nombre', [
            {
                rule: 'minLength',
                value: 3,
                errorMessage: 'Debe ingresar minimo 3 caracteres'
            },
            {
                rule: 'maxLength',
                value: 30,
                errorMessage: 'El maximo es de 30 caracteres'
            },
            {
                rule: 'required',
                errorMessage: 'Debe ingresar una descripcion'
            }
        ])

        .addField('#MarcaId', [
            {
                rule: 'required',
                errorMessage: 'Debe seleccionar una opcion'
            }
        ])

        .addField('#Stock', [
            {
                rule: 'required',
                errorMessage: 'Debe completar el campo'
            }
        ])

        .addField('#TipoId', [
            {
                rule: 'required',
                errorMessage: 'Debe seleccionar una opcion'
            }
        ])

        .addField('#Precio', [
            {
                rule: 'required',
                errorMessage: 'Debe completar el campo'
            }
        ])

        .addField('#UnidadId', [
            {
                rule: 'required',
                errorMessage: 'Debe completar el campo'
            }
        ])


        .onSuccess((event) => {
            $("form").submit();
        });
    console.log(validation);

});


function irAgregar() {
    window.location.href = '/Producto/Agregar';

}

function llenarComboMarca() {

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
        },
        error: function (xhr, status, error) {
            alert(xhr.status);
        }
    });

}


function llenarComboTipo() {

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
        },
        error: function (xhr, status, error) {
            alert(xhr.status);
        }
    });

}

function llenarComboUnidad() {

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
