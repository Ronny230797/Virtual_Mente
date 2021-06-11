//Variables

//Document Ready
$(document).ready(function () {
});


//Functions
(async () => {

    const { value: user } = await Swal.fire({
        title: 'Ingrese su usuario',
        input: 'text',
        inputPlaceholder: 'Usuario'
    })

    if (user) {
        saveLocalStorage('username',user);
        Swal.fire(`BIENVENIDO: ${user}`);
    }

})()


