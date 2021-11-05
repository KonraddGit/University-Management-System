
var TRange = null;

function search() {
    if (event.key === 'Enter') {
        var element = document.getElementById('searcher').value;
        if (parseInt(navigator.appVersion) < 4) return;
        var strFound;
        if (window.find) {
            var original_content = window;
            strFound = original_content.find(element);
            if (!strFound) {
                strFound = original_content.find(element, 0, 1);
                while (original_content.find(element, 0, 1)) continue;
            }

            else if (navigator.appName.indexOf("Microsoft") != -1) {

                if (TRange != null) {
                    TRange.collapse(false);
                    strFound = TRange.findText(element);
                    if (strFound) TRange.select();
                }
                if (TRange == null || strFound == 0) {
                    TRange = self.document.body.createTextRange();
                    strFound = TRange.findText(element);
                    if (strFound) TRange.select();
                }
            }
        }
    }
}



function searchInput() {

    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById("search");
    filter = input.value.toUpperCase();
    table = document.getElementById("myTable");
    tr = table.getElementsByTagName("tr");

    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("th")[1];
        if (td) {
            txtValue = td.textContent || td.innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
            } else {
                tr[i].style.display = "none";
            }
        }
    }
}
