<?php
    $tab = array("el_1", "el_2", "el_3", "el_4", "el_5");
    $dl = count($tab);
    for($i = 0; $i < $dl; $i++){
        echo $tab[$i] . " ";
    }
    echo "<hr>";

    $tab2 = array(3,2,5,7,9,0,1,4);
    echo "Zawartosc tablicy przed sortowaniem: <br>";
    foreach($tab2 as $x){
        echo $x . " ";
    }
    echo "<br>Zawartosc tablicy po sortowaniu: <br>";
    sort($tab2);
    foreach($tab2 as $x){
        echo $x . " ";
    }
    echo "<hr>";
    //Zad1
    $tab3 = array();
    for($i = 25; $i <= 50; $i++){
        if($i % 5 == 0){
            array_push($tab3, $i); 
        }
        rsort($tab3);
    }
    foreach($tab3 as $x){
        echo $x . " ";
    }
    echo "<hr>";
    //Zad2
    $even = 0;
    foreach($tab3 as $x){
        if($x % 2 == 0){
            $even++;
        }
    }
    echo $even;
    echo "<hr>";
    //Zad3
    $tabNames = array("Karol", "Maxiu", "Marcinek", "Jaca", "Max", "Magz");
    sort($tabNames);
    foreach($tabNames as $x){
        echo $x . " ";
    }
    echo "<hr>";
    //Zad4
    $dniTygodnia = array("Monday" => "Poniedziałek",
                        "Tuesday" => "Wtorek",
                        "Wednesday" => "Środa",
                        "Thursday" => "Czwartek",
                        "Friday" => "Piątek",
                        "Saturday" => "Sobota",
                        "Sunday" => "Niedziela");
    $miesiace = array("","Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień", "Pazdźernik", "Listopad", "Grudzień");
    $date = getdate();
    echo "Dziś jest " . $dniTygodnia[$date["weekday"]] . ".<br>" . $date["mday"] . " " . $miesiace[$date["mon"]] . " " . $date["year"] . " roku.";
    echo "<hr>";
    //Zad5
    echo "Zostało " . date_diff(new DateTime('now'), new DateTime("24-6-2022"))->days . " dni do Wakacji";
    

    echo date("Y-m-d") . "<br>";
    echo date("d-m-Y") . "<br>";
    echo date("G:i:s") . "<br>";
    echo date("H-i-sa") . "<br>";
    echo date("Y-m-d G:i:s") . "<br>";
    echo "<hr>";
    $czas = mktime(15,15,0,11,25,2022);
    echo date("D-m-Y G:i", $czas) . "<br>";
    echo date("Y-m-d G:i:s", $czas) . "<br>";
?>