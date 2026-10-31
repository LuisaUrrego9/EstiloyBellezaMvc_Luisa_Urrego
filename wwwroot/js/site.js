
document.addEventListener("DOMContentLoaded", function () {
    var formulario = document.querySelector(
        'form[asp-action="Registrar"]'
    );

    if (formulario == null) {
        formulario = document.querySelector("form");
    }

    if (formulario != null) {
        formulario.addEventListener("submit", function (evento) {
            var campoFecha = document.querySelector("#Fecha");

            if (campoFecha != null && campoFecha.value != "") {
                var fechaActual = new Date();
                fechaActual.setHours(0, 0, 0, 0);

                var fechaSeleccionada = new Date(
                    campoFecha.value + "T00:00:00"
                );

                if (fechaSeleccionada < fechaActual) {
                    evento.preventDefault();
                    alert("Selecciona una fecha igual o posterior a hoy.");
                }
            }
        });
    }
});
