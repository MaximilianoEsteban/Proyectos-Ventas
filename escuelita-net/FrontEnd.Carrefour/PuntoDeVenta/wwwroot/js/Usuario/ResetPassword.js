$(document).ready(function () {    
    
});

function irAgregar() {
    window.location.href = '/Account/ResetPassword';
}

function cargarFormulario(data) {
    $("#IdUsuario").val(data.IdUsuario);    
    $("#Password").val(data.Password);        
}
