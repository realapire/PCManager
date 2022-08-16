<?php

    $username = $_GET["username"];

    $connect = mysqli_connect("sql106.epizy.com", "epiz_30541862", "EG1DDkotFx", "epiz_30541862_mainDB");

    $query = mysqli_query($connect, "SELECT pcspecs_themeIndex, pcspecs_filterIndex FROM settings WHERE username='$username'");

    while ($row = mysqli_fetch_assoc($query))
    {
        echo "<p class='result1'>" . $row['pcspecs_themeIndex'] . "</p>";
        echo "<p class='result2'>" . $row['pcspecs_filterIndex'] . "</p>";
    }

    $connect -> close();

?>