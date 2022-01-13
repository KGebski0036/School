<!DOCTYPE HTML>
<html>
  <head>
    <title>Tabliczka mnożenia</title>
    <style>
    td { border: 1px solid black; }
    table {  border-collapse: collapse;}
    </style>
  </head>
  <body>
    <table>
    <?php
      echo "<tr>";
      for ($i=1; $i < 11; $i++) {
          if($i == 1){
            echo "<td></td>";
          }
          echo "<td><b>";
          echo $i;
          echo "</b></td>";
      }
      echo "</tr>";

      for ($i=1; $i < 11; $i++) {
        echo "<tr><td><b>";
        echo $i;
        echo "</b></td>";
        for ($j=1; $j < 11; $j++) {

          echo "<td>";
          echo $i * $j;
          echo "</td>";
        }
        echo "</tr>";
      }
     ?>
     </table>
  </body>
</html>
