<?php
if(isset($_POST["submit"])) {
    $username = $_POST["username"];
    $password = $_POST["password"];

    $connect = mysqli_connect("sql106.epizy.com", "epiz_30541862", "EG1DDkotFx", "epiz_30541862_mainDB");
    
    $encpassword = sha1($password);
    $query = mysqli_query($connect, "SELECT * FROM users WHERE username='$username' AND password='$encpassword'");
    
    if(mysqli_num_rows($query) > 0){
        session_start();
        $_SESSION["username"] = $username;
        header("location: profile.php");
        exit();
    } else {
        header("location: loginpage.php?error=notfound");
        exit();
    }

    $connect -> close();
} else {
    header("location: loginpage.php");
    exit();
}
?>