const modeloEmpleado =
{
    idEmpleado: 0,
    nombreCompleto:"",
    idDepartamento:0,
    sueldo:0,
    fechaContrato:""
}

function MostrarEmpleados()
{
    //Ahí va la ruta: home es homeController, lo otro es el método.
    //Son promesas, dentro de fetch, por eso pone .then, para hacerlo luego.
    fetch("/Home/ListaEmpleados")   
        .then(response => {
            return response.ok ? response.json() : Promise.reject(response)
            //Ahí devolvería la respuesta en formato JSON si la respuesta es correcta y si no la rechazaría.
        })
        .then(responseJson=> {
            if (responseJson.length > 0) {
                //1- Limpia la tabla:
                $("#tablaEmpleados tbody").html("");
                //Primero pone el id de table y luego especifica en qué parte de la tabla

                //2- Crea columna, con 5 filas, en la última mete 2 botones. Uno de editar, otro de eliminar.
                responseJson.forEach(empleado => {
                    $("#tablaEmpleados tbody").append(
                        $("<tr>").append(
                            $("<td>").text(empleado.nombreCompleto),
                            $("<td>").text(empleado.refDepartamento.nombre),
                            $("<td>").text(empleado.sueldo),
                            $("<td>").text(empleado.fechaContrato),
                            $("<td>").append(
                                $("<button>").addClass("btn btn-primary btn-sm boton-editarEmpleado").text("Editar").data("dataEmpleado",empleado),
                                $("<button>").addClass("btn btn-danger btn-sm ms-2 boton-eliminarEmpleado").text("Eliminar").data("dataEmpleado", empleado),
                            ),
                        )
                    )

                })

                

               }

        })
}
//Este evento se ejecuta cuando la página ha sido cargada
document.addEventListener("DOMContentLoaded", function ()
{
    MostrarEmpleados();
    fetch("/Home/ListaDepartamentos")
        .then(response => {
            return response.ok ? response.json() : Promise.reject(response)
        })
        .then(responseJson => {
        if (responseJson.length > 0) {
            responseJson.forEach(item => {
                $("#cboDepartamento").append(
                    $("<option>").val(item.idDepartamento).text(item.nombre)
                 )
            })
        }


    })

    $("#txtFechaContrato").datepicker({
        format: "dd/mm/yyyy",
        autoclose: true,
        todayHighlight:true
    })

}, false)

function MostrarModal() {
    $("#txtNombreCompleto").val(modeloEmpleado.nombreCompleto);
    //Si el idDepartamento es igual a 0, hace lo de option:first, si no usa el idDepartamento
    //Es como un if.
    $("#cboDepartamento").val(modeloEmpleado.idDepartamento == 0 ? $("#cboDepartamento option:first").val() : modeloEmpleado.idDepartamento);
    $("#txtSueldo").val(modeloEmpleado.sueldo);
    $("#txtFechaContrato").val(modeloEmpleado.fechaContrato);

    $("#modalEmpleado").modal("show");
}

//Evento que se ejecuta cuando se hace click sobre el botón Nuevo Empleado
$(document).on("click", ".boton-NuevoEmpleado", function () {
    modeloEmpleado.idEmpleado = 0;
    modeloEmpleado.nombreCompleto = "";
    modeloEmpleado.sueldo = 0;
    modeloEmpleado.fechaContrato = "";
    MostrarModal();

})

$(document).on("click", ".boton-editarEmpleado", function () {

    const _empleado=$(this).data("dataEmpleado")

    modeloEmpleado.idEmpleado = _empleado.idEmpleado;
    modeloEmpleado.nombreCompleto = _empleado.nombreCompleto;
    modeloEmpleado.sueldo = _empleado.sueldo;
    modeloEmpleado.idDepartamento = _empleado.refDepartamento.idDepartamento;
    modeloEmpleado.fechaContrato = _empleado.fechaContrato;
    MostrarModal();

})



$(document).on("click", "#boton-guardarCambiosEmpleado", function() {
    const modelo =
    {
        idEmpleado: modeloEmpleado.idEmpleado,
        nombreCompleto: $("#txtNombreCompleto").val(),
        refDepartamento: {
            idDepartamento: $("#cboDepartamento").val()
        },
        sueldo: $("#txtSueldo").val(),
        fechaContrato: $("#fechaContrato").val()
    }

    if (modeloEmpleado.idEmpleado == 0) {

        fetch("/Home/GuardarEmpleado",
            {
            method: "POST",
            headers: { "Content-Type": " application/json; charset=utf-8" },
            body: JSON.stringify(modelo)
            })
            .then(response => {
                return response.ok ? response.json() : Promise.reject(response)
            })
            .then(responseJson => {
                if (responseJson.valor) {
                    $("#modalEmpleado").modal("hide");
                    Swal.fire("¡Listo!", "El empleado fue creado", "Success");
                    MostrarEmpleados();
                }
                else {
                    Swal.fire("Ups","No se pudo crear el empleado", "Error");

                }

            })
    
    }
    else
    {
            fetch("/Home/EditarEmpleado",
            {
            method: "PUT",
            headers: { "Content-Type": "application/json; charset=utf-8" },
            body: JSON.stringify(modelo)
            })
            .then(response =>
            {
                return response.ok ? response.json() : Promise.reject(response)
            })
            .then(responseJson =>
            {
                if (responseJson.valor) {
                    $("#modalEmpleado").modal("hide");
                    Swal.fire("¡Listo!", "El empleado fue actualizado", "Success");
                    MostrarEmpleados();
                }
                else {
                    Swal.fire("Noooo", "No se pudo actualizar el empleado", "Error");
                }

            })
    }


})

