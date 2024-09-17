$(document).ready(function () {   
    const validation = new JustValidate('form');

    validation
        .addField('#Nombre', [
            {
                rule: 'minLength',
                value: 3,
                errorMessage: 'El minimo requerido es de al menos 3 caracteres'
            },
            {
                rule: 'maxLength',
                value: 30,
            },
            {
                rule: 'required',
                errorMessage: 'El nombre es un dato requerido'
            }
        ])
        .addField('#SubLineaId', [
            {
                rule: 'required',
                errorMessage: 'La sublinea es un dato requerido'
            }
        ])

        .onSuccess((event) => {
            $("form").submit();
        });


    console.log(validation);

    llenarComboSubLinea();
    
});

function irAgregar() {
    window.location.href = '/Tipo/Agregar';
}

function llenarComboSubLinea() {

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
        },
        error: function (xhr, status, error) {
            alert(xhr.status);
        }
    });

}
