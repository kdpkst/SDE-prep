// innerText only extracts and sets the visible text, ignoring any HTML tags inside the element
function innerTextExample() {
    const text = document.querySelector("#innerText");
    console.log(text.innerText);
    text.innerText = "New Text!";
}

// innerHTML extracts and sets the full HTML structure, including any nested elements and tags
function innerHTMLExample() {
    const html = document.querySelector("#innerHTML");
    console.log(html.innerHTML);
    html.innerHTML = "New <em>HTML</em> Content!";
}

function listReverse() {
    const list = document.querySelector("ol");
    // the 'reversed' attribute is a Boolean attribute and does not require a value
    // if the 'reversed' attribute is not set, getAttribute("reversed") returns null
    // if the 'reversed' attribute is set, getAttribute("reversed") returns an empty string ""
    const isReversed = list.getAttribute("reversed");
    if (isReversed == null) {
        list.setAttribute("reversed", "");
    } else {
        list.removeAttribute("reversed");
    }
}

const imageElement = document.querySelector("#MSlogo");
const imgSrc = imageElement.src;
console.log(imgSrc);

imageElement.src = "../../CSS/6-filters/kiwibird.jpg";