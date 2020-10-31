function MueveReloj() {
    var momentoActual = new Date();
    var hora = momentoActual.getHours();
    var minuto = momentoActual.getMinutes();
    var segundo = momentoActual.getSeconds();
    var horaMostrar ="Hora: "+ hora + ":" + minuto + ":" + segundo;
    //document.getElementById("Tiempo").innerHTML = horaMostrar;
    var valor = document.getElementById("temporizador").value;
    //document.getElementById("Segundo").innerHTML = valor;

    if (segundo==valor) {
        document.location.href = "http://localhost/Consulta";
        //document.getElementById("Minuto").innerHTML = "Se ha acaba el tiempo";

    }
    
    setTimeout("MueveReloj()",1000);
}

//(function MueveReloj(hora) {

//    hora.innerText = (new Date()).toString().match(/(?:[01]?\d|2[0-3]):[0-5]\d:[0-5]\d/)[0];
//    setTimeout(MueveReloj.bind(null, hora), 1000);
//})
//    (document.getElementById("Hora"));
