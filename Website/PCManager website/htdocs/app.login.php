<?php
    $username = $_GET["username"];
    $password = $_GET["password"];

    $connect = mysqli_connect("sql106.epizy.com", "epiz_30541862", "EG1DDkotFx", "epiz_30541862_mainDB");
    
    $encpassword = sha1($password);
    $query = mysqli_query($connect, "SELECT * FROM users WHERE username='$username' AND password='$encpassword'");
    
    if(mysqli_num_rows($query) > 0){
        echo "<p class='found'>OK</p>";
    } else {
        echo "<p class='failed'>Failed</p>";
    }

    $connect -> close();
?>