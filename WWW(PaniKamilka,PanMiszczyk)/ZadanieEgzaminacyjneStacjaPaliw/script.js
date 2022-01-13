function Oblicz(){
    var km = document.getElementById("km").valueAsNumber
    var l_km = document.getElementById("litry").valueAsNumber
    var result = km * (l_km/100)
    document.getElementById("result").innerHTML = "Potrzebujesz: " + result  + " litrów paliwa."
}
