$(document).ready(function () {    
    
});

function irAgregar() {
    window.location.href = '/Usuario/EditarPassword';
}

function cargarFormulario(data) {
    $("#IdUsuario").val(data.IdUsuario);    
    $("#Password").val(data.Password);        
}
