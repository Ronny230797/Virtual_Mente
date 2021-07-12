//Variables

//Document Ready
$(document).ready(function () {

    //deleteLocalStorage('rondaVirtualMente');
    //deleteLocalStorage('scoreVirtualMente');
    //deleteLocalStorage('scoreCuentaMente');
    //deleteLocalStorage('rondaCuentaMente');
    clearLocalStorage();

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


