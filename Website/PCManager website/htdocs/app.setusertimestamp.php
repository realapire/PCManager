<?php

    $username = $_GET["username"];
    $event = $_GET["event"];
    $timestamp = $_GET["timestamp"];

    $connect = mysqli_connect("sql106.epizy.com", "epiz_30541862", "EG1DDkotFx", "epiz_30541862_mainDB");

    switch($event) {
        case 1:
            $query = mysqli_query($connect, "UPDATE timestamps SET cleaner_timestamp='$timestamp' WHERE username='$username'");
            break;
        case 2:
            $query = mysqli_query($connect, "UPDATE timestamps SET renewip_timestamp='$timestamp' WHERE username='$username'");
            break;
        case 3:
            $query = mysqli_query($connect, "UPDATE timestamps SET releaseip_timestamp='$timestamp' WHERE username='$username'");
            break;
        case 4:
            $query = mysqli_query($connect, "UPDATE timestamps SET flushdns_timestamp='$timestamp' WHERE username='$username'");
            break;
    }

    if($query) {
        echo "<p>Succesful</p>";
    }

    $connect -> close();

?>