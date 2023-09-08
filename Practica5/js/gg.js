let intentos = 5;
let puntaje = 30;
let highscore = 0;
let numAlea = Math.floor((Math.random()*20)+1);
const valorInput = document.querySelector("#valor");
const botonIntento = document.querySelector("#boton");
const resetBoton = document.querySelector("#reset");

function iniciar(){
    const numI = Number(valorInput.value);
    console.log(numAlea);
    if(intentos != -1){
        if(numI==numAlea){
            pistas.textContent = "";
            document.getElementById("devuelve").innerHTML = `✔️ ¡ADIVINASTE! Puntaje: ${puntaje} ✔️`;
            valorInput.disabled = true;
            botonIntento.disabled = true;
            if(puntaje > highscore){
                highscore = puntaje
                document.getElementById("highScore").innerHTML = `Highscore:  ${highscore}`;
            }
            else{
                document.getElementById("highScore").innerHTML = `Highscore:  ${highscore}`;
            }
            resetBoton.disabled = false
        }
        else if(numI>numAlea){
            document.getElementById("pistas").innerHTML = `Pista: El número es menor. Vidas restantes: ${intentos}.`;
            intentos--;
            puntaje = puntaje - 5;
        }
        else if(numI<numAlea){
            document.getElementById("pistas").innerHTML = `Pista: El número es mayor. Vidas restantes: ${intentos}`;
            intentos--;
            puntaje = puntaje - 5;
        }  
    }
    else {
        pistas.textContent = "";
        document.getElementById("devuelve").innerHTML = `❌ PERDISTE... YA NO TE QUEDAN VIDAS. ❌`;
        valorInput.disabled = true;
        botonIntento.disabled = true;
        resetBoton.disabled = false;
    }
}

function resetL(){
    numAlea = Math.floor((Math.random()*20)+1);
    intentos = 5;
    puntaje = 30;
    botonIntento.disabled = false;
    valorInput.disabled = false;
    devuelve.textContent = "";
    pistas.textContent = "";
    resetBoton.disabled = true;
}

botonIntento.addEventListener("click", ()=>{
    if(valorInput.value.length == 0){
        alert('Para jugar ingrese un número');
    }else{
        iniciar();
    }
});
resetBoton.addEventListener("click", resetL);