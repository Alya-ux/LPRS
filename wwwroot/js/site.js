
// Filter by Date
function filterByDate() {
    let startDate = document.getElementById('start-date').value;
    let endDate = document.getElementById('end-date').value;
    alert("Filtering data from " + startDate + " to " + endDate);
}

// Search License Plate
function searchPlate() {
    let input = document.getElementById("search-input").value.toUpperCase();
    let table = document.getElementById("report-table");
    let rows = table.getElementsByTagName("tr");

    for (let i = 1; i < rows.length; i++) {
        let plateCell = rows[i].getElementsByTagName("td")[2]; // License plate column
        if (plateCell) {
            let plateText = plateCell.textContent || plateCell.innerText;
            rows[i].style.display = plateText.toUpperCase().includes(input) ? "" : "none";
        }
    }
}

// Export to CSV
function exportToCSV() {
    let table = document.getElementById("report-table");
    let rows = table.querySelectorAll("tr");
    let csvContent = [];

    rows.forEach(row => {
        let cols = row.querySelectorAll("td, th");
        let rowData = [];
        cols.forEach(col => rowData.push(col.innerText));
        csvContent.push(rowData.join(","));
    });

    let csvFile = new Blob([csvContent.join("\n")], { type: "text/csv" });
    let downloadLink = document.createElement("a");
    downloadLink.href = URL.createObjectURL(csvFile);
    downloadLink.download = "license_plate_report.csv";
    document.body.appendChild(downloadLink);
    downloadLink.click();
    document.body.removeChild(downloadLink);
}

// Show Total Count
/*window.onload = function () {
    let rowCount = document.getElementById("report-table").rows.length - 1; // Exclude header
    document.getElementById("total-count").innerText = rowCount;*/
};
