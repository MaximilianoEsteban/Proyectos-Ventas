$(document).ready(function () {
    const validation = new JustValidate('form');

    validation
        .addField('#descripcion', [
            {
                rule: 'minLength',
                value: 3,
                errorMessage: 'Se requieren al menos 3 caracteres de descripcion para guardar una linea'
            },
            {
                rule: 'maxLength',
                value: 30,
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
});


function irAgregar() {
    window.location.href = '/Unidad/Agregar';
}
    
