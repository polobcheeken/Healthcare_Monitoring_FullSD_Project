function AddDataTable(table) {
    $(document).ready(function () {
        $(table).DataTable();
    })
}
function DataTableDispose(table) {
    $(document).ready(function () {
        $(table).DataTable().destroy();
        var element = document.querySelector(table + '_wrapper');
        element.parentNode.removeChild(element);
    })
}