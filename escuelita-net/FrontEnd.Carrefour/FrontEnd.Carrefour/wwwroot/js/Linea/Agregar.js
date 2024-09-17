$(document).ready(function () {
    const validation = new JustValidate('form');

    validation
        .addField('#Descripcion', [
            {
                rule: 'minLength',
                value: 3,
                errorMessage: 'Debe ingresar mas de tres caracteres',
            },
            {
                rule: 'maxLength',
                value: 10,
                errorMessage: 'Supera la cantidad maxima de caracteres',

            },
            {
                rule: 'required',
                errorMessage: 'La descripcion es un dato requerido'
            }
        ])
        .onSuccess((event) => {
            $("form").submit();
        });

    console.log(validation);
})


function irAgregar() {
    window.location.href = '/Linea/Agregar';
}