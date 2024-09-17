$(document).ready(function () {
    onClickGuardarPostAjax();
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
                value: 50,
                errorMessage: 'El maximo es de 30 caracteres'
            },
            {
                rule: 'required',
                errorMessage: 'Debe ingresar un nombre'
            }
        ])

        .onSuccess((event) => {
            $("form").submit();
        });
    console.log(validation);
 
});

function irAgregar() {
    window.location.href = '/Perfil/Agregar';

    
}



function onClickGuardarPostAjax() {
    $("#btnGuardarPostAjax").on("click", function () {

        var SendInfo = {
            "Nombre": $("#Nombre").val(),

        };
        var obj = { "model": SendInfo };

        $.ajax({
            type: 'post',
            url: '/Perfil/Agregar',
            data: JSON.stringify(obj),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                console.log(data)
            }
        });
    })
}
