async function requests() {
    let response = await fetch(`https://trex-sandwich.com/ajax/articles?id=1`);
    let jsonObject = await response.json();
    return jsonObject;
}

async function main() {
    const jsonObject = await requests();
    console.log(JSON.stringify(jsonObject));
}

main();