
function format(d) {
    // `d` is the original data object for the row
    return (
        '<dl>' +
        '<dt>Saldos:</dt>' +
        '<dd>' +
        d +
        '</dd>'
    );
}

let table = $('#table_id').DataTable({
    ajax: '/Gestor/getGestores',
    columns: [
        {
            className: 'dt-control',
            orderable: false,
            data: null,
            defaultContent: ''
        },
        { data: "IdGestor", "width": "25%" },
        { data: "Gestor", "width": "25%" },
        { data: "Activo", "width": "25%" },
    ],
    order: [[1, 'dsc']]
});

// Add event listener for opening and closing details
table.on('click', 'td.dt-control', function (e) {
    let tr = e.target.closest('tr');
    let row = table.row(tr);

    if (row.child.isShown()) {
        // This row is already open - close it
        row.child.hide();
    }
    else {

        console.log(row.data().gestorSaldoDetalleEntities)
        var arr = new Array();
        $.each(row.data().gestorSaldoDetalleEntities, function (key, value) {
            console.log(value.Monto);
            arr.push(value.Monto)
        });
        console.log(arr);
        row.child(format(arr)).show();
    }
});


