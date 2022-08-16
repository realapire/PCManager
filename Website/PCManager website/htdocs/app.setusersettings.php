<?php

    $username = $_GET["username"];
    $themeindex = $_GET["theme"];
    $filterindex = $_GET["filter"];

    $connect = mysqli_connect("sql106.epizy.com", "epiz_30541862", "EG1DDkotFx", "epiz_30541862_mainDB");

    $query = mysqli_query($connect, "UPDATE settings SET pcspecs_themeIndex='$themeindex', pcspecs_filterIndex='$filterindex' WHERE username='$username'");

    if($query){
        echo "<p>Succesful</p>";
    }

    $connect -> close();

?>