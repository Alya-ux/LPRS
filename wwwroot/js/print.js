function PrintTable() {
    var content = document.getElementById('print-section').innerHTML;
    var printWindow = window.open('', '_blank', 'width=800,height=600');
    printWindow.document.open();
    printWindow.document.write(`
        <html>
        <head>
            <title>Print Report</title>
            <style>
                body { font-family: Arial, sans-serif; padding: 20px; }
                table { width: 100%; border-collapse: collapse; }
                th, td { border: 1px solid #ccc; padding: 8px; text-align: center; }
                img { max-width: 100px; height: auto; }
                .btn-print {
                    padding: 10px 16px;
                    background-color: #007bff;
                    color: white;
                    border: none;
                    border-radius: 4px;
                    cursor: pointer;
                    font-size: 16px;
                    margin-bottom: 20px;
                }
            </style>
        </head>
        <body>
            <h2>License Plate Recognition Report</h2>
            <button class="btn-print" onclick="window.print()">Print Now</button>
            ${content}
        </body>
        </html>
    `);
    printWindow.document.close();
}
