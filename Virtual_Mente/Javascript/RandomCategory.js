let category = () => {
    var things = ['Ingles', 'Matematicas', 'Ciencias', 'Estudios Sociales', 'Español'];
    var thing = things[Math.floor(Math.random() * things.length)];
    var output = document.getElementById('output');
    $('#materia').val(output);
    output.innerHTML = thing;
}