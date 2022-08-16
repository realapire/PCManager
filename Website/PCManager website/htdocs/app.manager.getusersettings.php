<?php

    $username = $_GET["username"];

    $connect = mysqli_connect("sql106.epizy.com", "epiz_30541862", "EG1DDkotFx", "epiz_30541862_mainDB");

    $query = mysqli_query($connect, "SELECT pcmanager_themeIndex FROM settings WHERE username='$username'");

    while ($row = mysqli_fetch_assoc($query))
    {
        echo "<p class='result'>" . $row['pcmanager_themeIndex'] . "</p>";
    }

    $connect -> close();

?>