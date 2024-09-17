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
        .addField('#LineaId', [            
            {
                rule: 'required',
                errorMessage: 'La linea es un dato requerido'
            }
        ])

    .onSuccess((event) => {
        $("form").submit();
    });   

    console.log(validation);

    llenarComboLinea();   
});

function llenarComboLinea() {

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
        },
        error: function (xhr, status, error) {
            alert(xhr.status);
        }
    });

}
