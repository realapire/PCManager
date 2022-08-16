<?php

    $username = $_GET["username"];

    $connect = mysqli_connect("sql106.epizy.com", "epiz_30541862", "EG1DDkotFx", "epiz_30541862_mainDB");

    $query = mysqli_query($connect, "SELECT DISTINCT class FROM win32classes WHERE username='$username'");

    while ($row = mysqli_fetch_assoc($query))
    {
        echo "<p class='result'>" . $row['class'] . "</p>";
    }

    $connect -> close();

?>