$(document).ready(function () {
    llenarComboPerfil();
    const validation = new JustValidate('form');

    validation
        .addField('#IdUsuario', [
            {
                rule: 'minLength',
                value: 8,
                errorMessage: 'El minimo requerido es de al menos 8 caracteres.'
            },
            {
                rule: 'maxLength',
                value: 50,
            },
            {
                rule: 'required',
                errorMessage: 'El username es un dato requerido Se debe alternar la primer letra del nombre, seguido del apellido'
            }
        ])
        .addField('#Nombre', [
            {
                rule: 'minLength',
                value: 3,
                errorMessage: 'El minimo requerido es de al menos 8 caracteres'
            },
            {
                rule: 'maxLength',
                value: 50,
            },
            {
                rule: 'required',
                errorMessage: 'El nombre es un dato requerido'
            }
        ])
        .addField('#Apellido', [
            {
                rule: 'minLength',
                value: 3,
                errorMessage: 'El minimo requerido es de al menos 3 caracteres'
            },
            {
                rule: 'maxLength',
                value: 50,
            },
            {
                rule: 'required',
                errorMessage: 'El apellido es un dato requerido'
            }
        ])
        .addField('#Email', [
            {
                rule: 'minLength',
                value: 3,
                errorMessage: 'El minimo requerido es de al menos 3 caracteres'
            },
            {
                rule: 'maxLength',
                value: 50,
            },
            {
                rule: 'required',
                errorMessage: 'El correo electronico es un dato requerido'
            }
        ])
        .addField('#Password', [
            {
                rule: 'minLength',
                value: 4,
                errorMessage: 'El minimo requerido es de al menos 4 caracteres'
            },
            {
                rule: 'maxLength',
                value: 50,
            },
            {
                rule: 'required',
                errorMessage: 'La password es un dato requerido'
            }
        ])
        .addField('#Password1', [
            {
                rule: 'minLength',
                value: 4,
                errorMessage: 'El minimo requerido es de al menos 4 caracteres'
            },
            {
                rule: 'maxLength',
                value: 50,
            },
            {
                rule: 'required',
                errorMessage: 'La confirmacion de password es un dato requerido'
            }
        ])            

    .onSuccess((event) => {
        $("form").submit();
    });   

    console.log(validation);
    
});

function llenarComboPerfil() {

    $.ajax({
        type: "GET",
        url: "/Perfil/ListarPerfilesParaCombos",
        dataType: "json",
        contentType: "application/json",
        success: function (data) {
            console.log(data);
            $.each(data, function (i, Perfil) {

                $('#IdPerfil').append('<option value="Cliente"></option>');
            });
        },
        error: function (xhr, status, error) {
            alert(xhr.status);
        }
    });

}
