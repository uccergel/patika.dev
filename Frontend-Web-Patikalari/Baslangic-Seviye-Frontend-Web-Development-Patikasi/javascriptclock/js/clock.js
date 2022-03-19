let fullName = prompt("Lütfen Adınızı ve Soyadınızı Giriniz: ");
let myName = document.querySelector("#myName");
myName.innerHTML = `${fullName}`

function date() {
let date = new Date().toLocaleTimeString();
let dateDay = new Date();
let days = [
    "Pazar",
    "Pazartesi",
    "Salı",
    "Çarşamba",
    "Perşembe",
    "Cuma",
    "Cumartesi"
]
let myClock = document.querySelector("#myClock")
myClock.innerHTML = `${date} ${days[dateDay.getDate()]}`
}

setInterval(date, 1000);