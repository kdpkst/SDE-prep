function generateTable() {
    const tableArea = document.querySelector("#multiplication-table");
    for (let i = 1; i < 10; i++) {
        const row = document.createElement("p");
        let line = "";
        for (let j = 1; j < i + 1; j++) {
            j == i ? line += `${i} * ${j} = ${i * j}`: line += `${i} * ${j} = ${i * j}, `;    
        }
        row.textContent = line;
        tableArea.appendChild(row);
    }
}

generateTable();