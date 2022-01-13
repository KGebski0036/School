<?php 

//Zad 1
$Celcjusze = 100;
$Fahrenheita = (($Celcjusze * 9) / 5) + 32;
echo "Celc: " . $Celcjusze . " Farh: " . $Fahrenheita . "<br>";  

//Zad 2
$Fahrenheita2 = 212;
$Celcjusze2 = (($Fahrenheita2 - 32) * 5) / 9;
echo "Celc2: " . $Celcjusze2 . " Farh2: " . $Fahrenheita2 . "<br>";

//Zad 3
$bokA = 3;
$bokB = 4;
$bokC = 7;

if($bokA + $bokB > $bokC && $bokA + $bokC > $bokB && $bokB + $bokC > $bokA){
    echo "Trójkąt można zbudować <br>";
}else{
    echo "Trójkąta nie można zbudować <br>";
}

//Zad 4
$miesiac = "luty";

if($miesiac == "marzec" || $miesiac == "kwiecien" || $miesiac == "maj"){
    echo "Mamy wiosnę<br>";
}
else if($miesiac == "czerwiec" || $miesiac == "lipiec" || $miesiac == "sierpień"){
    echo "Mamy lato<br>";
}
else if($miesiac == "wrzesien" || $miesiac == "pazdziernik" || $miesiac == "listopad"){    
    echo "Mamy jesień<br>";
}else{
    echo "Mamy zimę<br>";
}

//Zad 5
$liczba1 = 1;
$liczba2 = 4;
$liczba3 = 10;

echo ($liczba1 + $liczba2 + $liczba3) / 3 . "<br>";

//Zad 6
$medLiczba1 = 3;
$medLiczba2 = 1;
$medLiczba3 = 3;
$wynik;
if($medLiczba1 >= $medLiczba2 && $medLiczba1 <= $medLiczba3 || $medLiczba1 <= $medLiczba2 && $medLiczba1 >= $medLiczba3){
    $wynik = $medLiczba1;
}else if($medLiczba2 >= $medLiczba1 && $medLiczba2 <= $medLiczba3){
    $wynik = $medLiczba2;
}else{
    $wynik = $medLiczba3;
}

echo $wynik . "<br>"; 

//Zad 7
echo "<h2>Karol Gębski</h2><br>";

//Zad 8
$dziesietnyP = 7;
$dziesietnyU = -25; 

$osemkowyP = octdec(7);
$osemkowyU = octdec(-25);

$szestnastkowyP = hexdec(7);
$szestnastkowyU = hexdec(-25);

//Zad 9
$osoby = array(
    array("Karol","Gębski","821938292387","Leszczyny"),
    array("Jacek","Gębski","121438292387","Masłów"),
    array("Marcinek","Gębski","821938292387","Jaawożnia"),
    array("Kostek","Gębski","645648292387","Kielce"),
    array("Bomba","Gębski","045058292387","Kielce")
);
for($i = 0;$i < 5;$i++){
    for($j = 0;$j < 4;$j++){
        echo $osoby[$i][$j] . " ";
    }
    echo "<br>";
}

//Zad 10
define("PI", 3.14);
echo "Pole koła: " . PI*(4 * 4) . "<br>";

//Zad 11
$x = 2;
$y = 4;

switch($x * $y){
    case 10:
        echo "Wynik to 10<br>";
        break;
    case 20:
        echo "Wynik to 20<br>";
        break;
    case 30:
        echo "Wynik to 30<br>";
        break;
    case 40:
        echo "Wynik to 40<br>";
        break;
    default:
        echo "Wynik mnożenia nieznany";
}
?>