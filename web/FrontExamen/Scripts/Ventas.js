function VentasXArticulo() {
    var contenido = '';
    var ventaGlobal=0;
    $.ajax({
        type: 'GET',
        url: "https://localhost:7109/examen/mostrarProductos",
        data: {
          
        },
        success: function (data) {
            if (data.error != null) {
                Swal.fire('Error', data.error, "warning");
            } else {
                productos = data;
                productos.sort(function (a, b) {
                    return b.totalVendido - a.totalVendido;
                });
                for (var i = 0; i < productos.length; i++) {
                    contenido += '<tr class="text-center">' +
                        '<td>' + productos[i].titulo+ '</td>' +
                        '<td>' + productos[i].totalVendido+ " $" + '</td>' +
                        '<td>' + productos[i].precioUnitario + " $" + '</td>' 
                    '</tr>';
                    ventaGlobal = ventaGlobal + parseFloat(productos[i].totalVendido);
                    

                }
                console.log(ventaGlobal)
                Globales('<h1 class="text-danger">'+ventaGlobal+'$ Pesos'+'</h1>')

                $('#tbody').html(contenido);
            }
        },
        error: function (xhr, status, error) {
            console.log(xhr);
            console.log(status);
            console.log(error);
        }
    });
}

function Globales(Globales) {
    $('#global').html(Globales);
}

function Ventas() {
    var contenido = '';
    var fecha;
    $.ajax({
        type: 'GET',
        url: "https://localhost:7109/examen/mostrarVentas",
        data: {

        },
        success: function (data) {
            if (data.error != null) {
                Swal.fire('Error', data.error, "warning");
            } else {
                ventas = data;

                for (var i = 0; i < ventas.length; i++) {

                    fechaCompleta = ventas[i].fecha;
                    let fecha = fechaCompleta.split("T")[0];
                    contenido += '<tr class="text-center">' +
                        '<td>' + ventas[i].idVentas + '</td>' +
                        '<td>' + ventas[i].producto.idProductos + '</td>' +
                        '<td>' + ventas[i].producto.titulo + '</td>' +
                        '<td>' + ventas[i].producto.descripcion + '</td>' +
                        '<td>' + ventas[i].producto.precioUnitario + '</td>' +
                        '<td>' + ventas[i].producto.existencias + '</td>' +
                        '<td>' + ventas[i].cantidadVendida + '</td>' +
                        '<td>' + fecha + '</td>' +
                        '<td>' + parseFloat(ventas[i].producto.precioUnitario) * parseInt(ventas[i].cantidadVendida) + '</td>' +
                        '</tr>';
                }

                $('#tbody').html(contenido);
            }
        },
        error: function (xhr, status, error) {
            console.log(xhr);
            console.log(status);
            console.log(error);
        }
    });
}


function MasVendidos() {
    var contenido = '';
    $.ajax({
        type: 'GET',
        url: "https://localhost:7109/examen/mostrarProductos",
        data: {

        },
        success: function (data) {
            if (data.error != null) {
                Swal.fire('Error', data.error, "warning");
            } else {
                productos = data;
                productos.sort(function (a, b) {
                    return b.cantidadVendida - a.cantidadVendida;
                });

                for (var i = 0; i < productos.length; i++) {
                    contenido += '<tr class="text-center">' +
                        '<td>' + productos[i].titulo + '</td>' +
                        '<td>' + productos[i].cantidadVendida + '</td>' 
                    '</tr>';

                }

                $('#tbody').html(contenido);
            }
        },
        error: function (xhr, status, error) {
            console.log(xhr);
            console.log(status);
            console.log(error);
        }
    });
}

function Existenacias() {
    var contenido = '';
    var tabla = '<table style="border-collapse: collapse; width: 100%;">';
    tabla += '<tr><th style="background-color: #f2f2f2; padding: 8px; border: 1px solid #ddd;">Titulo</th><th style="background-color: #f2f2f2; padding: 8px; border: 1px solid #ddd;">Existencias</th></tr>';

    $.ajax({
        type: 'GET',
        url: "https://localhost:7109/examen/mostrarProductos",
        data: {

        },
        success: function (data) {
            if (data.error != null) {
                Swal.fire('Error', data.error, "warning");
            } else {
                productos = data;
                productos.sort(function (b, a) {
                    return b.existencias - a.existencias;
                });

                for (var i = 0; i < productos.length; i++) {
                    contenido += '<tr class="text-center">' +
                        '<td>' + productos[i].titulo + '</td>' +
                        '<td>' + productos[i].existencias + '</td>'
                    '</tr>';

                    if (parseInt(productos[i].existencias) < 100) {
                        tabla += '<tr><td style="padding: 8px; border: 1px solid #ddd;">' + productos[i].titulo
                            + '</td><td style="padding: 8px; border: 1px solid #ddd;">' + productos[i].existencias + '</td></tr>';
                       

                    }

                }
                tabla += '</table>';

                Swal.fire({
                    title: 'Productos por debajo de las 100 unidades',
                    text:'Favor de comprar a proveedor',
                    html: tabla
                });          


                $('#tbody').html(contenido);
            }
        },
        error: function (xhr, status, error) {
            console.log(xhr);
            console.log(status);
            console.log(error);
        }
    });
}

