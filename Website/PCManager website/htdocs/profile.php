<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PCManager | <?php session_start(); if(isset($_SESSION['username'])) { echo $_SESSION['username']; } else { header("location: index.php"); exit(); } ?></title>
    <link rel="stylesheet" href="styles/main.css">
    <link rel="stylesheet" href="styles/profile.css">
</head>

<body style="background: url('images/background-image.png') center top / cover no-repeat;">
    <?php
        include_once 'navbar.php';
    ?>

    
    <div class="welcome-text">
        <?php

        if(isset($_SESSION["username"])) {
            echo "<h1>Hi there, ". $_SESSION['username'] ."</h1>";
        } else {
            header("location: index.php");
            exit();
        }

        ?>
    </div>
    
    <div class="panel-holder">
        <div class="panel">
            <h1 class="panel-title">PCManager</h1>
            <div class="information">
                <h3>Timestamps</h3>

                <?php
                    if(isset($_SESSION["username"])) {
                        $username = $_SESSION["username"];

                        $connect = mysqli_connect("sql106.epizy.com", "epiz_30541862", "EG1DDkotFx", "epiz_30541862_mainDB");

                        $query = mysqli_query($connect, "SELECT * FROM timestamps WHERE username='$username'");

                        while ($row = mysqli_fetch_assoc($query))
                        {
                            echo "<h6>Cleaning PC<span style='float:right; color:rgba(255,255,255,0.5)'>" . $row['cleaner_timestamp'] . "</span></h6>";
                            echo "<h6>Renewing IP<span style='float:right; color:rgba(255,255,255,0.5)'>" . $row['renewip_timestamp'] . "</span></h6>";
                            echo "<h6>Releasing IP<span style='float:right; color:rgba(255,255,255,0.5)'>" . $row['releaseip_timestamp'] . "</span></h6>";
                            echo "<h6>Flushing DNS<span style='float:right; color:rgba(255,255,255,0.5)'>" . $row['flushdns_timestamp'] . "</span></h6>";
                        }

                        $connect -> close();
                    } 
                ?>
                
            </div>
        </div>
        <div class="panel">
            <h1 class="panel-title">PCSpecs</h1>
            <div class="settings">
            <div class="information">
                <h3>Recently used classes</h3>
                <ul>

                <?php

                    $username = $_SESSION["username"];
                    $connect = mysqli_connect("sql106.epizy.com", "epiz_30541862", "EG1DDkotFx", "epiz_30541862_mainDB");
                    $query = mysqli_query($connect, "SELECT DISTINCT class FROM win32classes WHERE username='$username'");
                    for ($x = 0; $x < 5; $x++) {
                        $row = mysqli_fetch_assoc($query);
                        echo "<li><h6>" . $row['class'] . "</h6>";
                    }

                    $connect -> close();

                ?>

                </ul>
                
            </div>
        </div>
    </div>
    

</body>
</html>