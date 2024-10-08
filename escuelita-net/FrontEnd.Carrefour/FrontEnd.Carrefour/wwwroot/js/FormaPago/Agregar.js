﻿$(document).ready(function () {
    const validation = new JustValidate('form');

    validation
        .addField('#FormaPago', [
            {
                rule: 'minLength',
                value: 3,
                errorMessage: 'Debe ingresar mas de tres caracteres',
            },
            {
                rule: 'maxLength',
                value: 50,
                errorMessage: 'Supera la cantidad maxima de caracteres',

            },
            {
                rule: 'required',
                errorMessage: 'El nombre de la forma de pago es un dato requerido'
            }
        ])
        .onSuccess((event) => {
            $("form").submit();
        });

    console.log(validation);
})

function irAgregar() {
    window.location.href = '/FormaPago/Agregar';
}