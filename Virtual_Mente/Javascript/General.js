//Local Storage
//To Help: https://blog.logrocket.com/localstorage-javascript-complete-guide/
let saveLocalStorage = (key, value) => {
    window.localStorage.setItem(`${key}`, `${value}`);
}

let getLocalStorage = (key) => {
    JSON.parse(window.localStorage.getItem(`${key}`));
}

let clearLocalStorage = () => {
    window.localStorage.clear();
}

let deleteLocalStorage = (key) => {
    window.localStorage.removeItem(key);
}