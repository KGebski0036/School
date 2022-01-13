<!DOCTYPE HTML>
<html>
<head>
<title>Zadanie na ocene</title>
</head>
<body>

	
    <?php
		//Zad1
        for($i = 1000; $i<=5000; $i++)
        {
            if($i%11==0)
            {
                echo $i . " ";
            }
        }
		echo "<hr>";
	?>
	
	
	<form method="get" action="zadanianaocene.php">
		Podaj n: <input type="number" name="danezad2"/>
		<button type="submit">Rysuj</button>
	</form>
	<?php
	//Zad 2
		$n = $_GET["danezad2"];
		
		for($i = 0; $i < $n; $i++){
			if($i < $n/2){
				for($j = 0; $j < $i + 1; $j++){
					echo "*";
				}
			}else{
				for($j = 0; $j < $n - $i; $j++){
					echo "*";
				}
			}
			
			echo "<br>";
		}
		echo "<hr>";
		
	//Zad 4
		for($i = 0 ; $i<=10; $i++){
			if($i % 3 != 0) echo $i . " ";
		}
		echo "<hr>";

	//Zad 5
	$x = 0;    
    $y = 1; 
    echo $y . " ";
    for($i=0;$i<29;$i++)    
    {    
        $fib = $x + $y;    
        echo $fib . " ";         
        $x=$y;       
        $y=$fib;     
    } 
    echo "<hr>";
	//Zad 6
	$x = 0;    
    $y = 1; 
	$fib = 0;
	while(true){
		
		$fib = $x + $y;  
		if($fib > 100){
        	 break;
		}else if($fib > 5){
			echo $fib . " "; 
		}      
        $x=$y;       
        $y=$fib;  
	}
	echo "<hr>";
	?>
	<form method="get" action="zadanianaocene.php">
		Podaj liczbę binarną: <input type="text" name="danezad7"/>
		<button type="submit">Licz</button>
	</form>
	<?php
	//Zad 7
		$bin = $_GET["danezad7"];
		echo bindec($bin);
		echo "<hr>";
	?>
	<form method="get" action="zadanianaocene.php">
		Podaj liczbę 1: <input type="text" name="danezad8"/>
		Podaj liczbę 2: <input type="text" name="danezad8-2"/>
		<button type="submit">Licz</button>
	</form>
	<?php
	//Zad 8
		$liczba1 = $_GET["danezad8"];
		$liczba2 = $_GET["danezad8-2"];
		$suma = 0;
		for($i = $liczba1 + 1 ; $i < $liczba2; $i++){
			$suma += $i; 
		}
		echo $suma;
		echo "<hr>";
	//Zad 9
		for($i = 1; $i <= 9; $i++){
			for($j = 0; $j < $i ; $j++){
				echo $i;
			
			}
			echo "<br>";
		}
		echo "<hr>";

	//Zad 10
		for($i = 1; $i <= 5; $i++){
			for($j = 0; $j < $i ; $j++){
				echo "*";
			
			}
			echo "<br>";
		}
		echo "<hr>";
	//Zad 12
		$h = 10;
		echo "<p style='font-family:monospace'>";
		for($i = 1; $i <= $h; $i++){
			for($k = 0; $k < $h  - $i / 2; $k++){
				echo "&nbsp;";
			}
			
			for($j = 0; $j < $i ; $j++){
				
				echo "*";
			
			}
		
			echo "<br>";
		}
		echo "</p>";
		echo "<hr>";
	?>
</body>
</html>