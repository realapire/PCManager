<?php

$username = $_GET["username"];
$class = $_GET["class"];

$connection = mysqli_connect("sql106.epizy.com", "epiz_30541862", "EG1DDkotFx", "epiz_30541862_mainDB");

$insert = "INSERT INTO win32classes (username, class) VALUES ('$username', '$class')";

if ($connection->query($insert) === TRUE) {
        echo "<p class='succesful'>Succesful</p>";
}

$connection -> close();

?>