<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Zadanka</title>
</head>
<body>
    <?php
    //Zad1
        if(file_exists('plik.txt'))
        {
            echo "Znaleziono plik";
        } 
        else
        {
            echo "Nie znaleziono pliku";
        }
    //Zad2
        echo "<hr>";
        if(file_exists('plik.txt'))
        {
            echo filesize('plik.txt');
        }
        else
        {
            echo "Nie znaleziono pliku";
        }
    //Zad3

        echo "<hr>";
        touch('temp.txt');
        echo "Utworzono plik temp.txt<br>";
        if(file_exists('temp.txt'))
        {
            echo "Usunięto plik temp.txt";
            unlink('temp.txt');
        }
        else
        {
            echo "Plik się nie utworzył :(";
        }

    //Zad4
        echo "<hr>";
    ?>
    
    <form method="get">
    Podaj imie: <input name="name" type="text"/><br>
    Podaj nazwisko: <input name="surname" type="text"/><br>
    <input type="submit">
    </form>

    <?php
        echo "<hr>";
        $name = $_GET["name"] . "\n";
        $surname = $_GET["surname"] . "\n";
        if(file_exists('dane.txt'))
        {
            if($file = fopen('dane.txt', 'a'))
            {
                if($name != "\n" &&  $surname != "\n")
                {
                    fwrite($file, $name);
                    fwrite($file, $surname);
                    fclose($file);
                    echo "Imie zostało zapisane";
                } 
                else
                {
                    echo "Uzupełnij pola";
                } 
            }    
        }
        else
        {
            echo "Nie znaleziono pliku dane.txt";
        }
    //Zad5
        echo "<hr>";
        if(file_exists('dane.txt'))
        {
            if($file = fopen('dane.txt', 'r'))
            {
                while(!feof($file))
                {
                    echo fgets($file) . "<br>";
                }
            }
            fclose($file);
        }
        else
        {
            echo "Nie znaleziono pliku";
        }
    //Zad6
        echo "<hr>";
        $counter = 0;

        if($file = fopen('licznik.txt', 'r'))
        {
            
            $counter = intval(fgets($file));
            $counter++;
            fclose($file);
            echo "Licznik: $counter";

            $file = fopen('licznik.txt', 'w');
            fwrite($file, $counter);
            fclose($file);
                     
        }
        else
        {
            echo "Nie znaleziono pliku";
        }
        
    ?>
    
</body>
</html>





