ns('LogisticaAppMVC.Cliente.Index');

try {

    $(document).ready(function () {
        'use strict';
        debugger;
        $('#btnAgregarCliente').on('click', function () {
            debugger;
            agregarCliente();
        });

    });

    function agregarCliente() {
        var nombre = $('#txtNombre').val();
        var apellido = $('#txtApellido').val();
        var email = $('#txtEmail').val();
        var telefono = $('#txtTelefono').val();
        var direccion = $('#txtDireccion').val();

        var oData = {
            Nombre: nombre,
            Apellido: apellido,
            Email: email,
            Telefono: telefono,
            Direccion: direccion
        };

        $.ajax({
            url: '/Cliente/AddCliente',
            data: oData,
            method: 'POST',
            dataType: 'json',
            success: function (response) {
                var objData = jQuery.parseJSON(response);
            },
            failure: function (msg) {
                console.log("entro a la función failure");
                console.log(msg);
            },
            error: function () {
                console.log("ERROR: No se ha podido obtener la información");
            },
        });
    }

} catch (ex) {
    alert(ex.message);
}