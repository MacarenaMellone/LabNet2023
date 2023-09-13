const boton = document.querySelector('#boton');
const frase = document.querySelector('#frase');
boton.addEventListener('click', getData);
async function getData() {
    try {
        const data = await fetch('https://rickandmortyapi.com/api/character/1,183');
        const json = await data.json();
        //console.log(json);
        console.log(json);
        frase.textContent = json;
        console.log(json.id);
    }
    catch (e) {
        console.error(e);
    }
}