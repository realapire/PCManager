<?php

if(isset($_POST["submit"])) {
    $username = $_POST["username"];
    $password = $_POST["password"];
    $cpassword = $_POST["cpassword"];

    $connection = mysqli_connect("sql106.epizy.com", "epiz_30541862", "EG1DDkotFx", "epiz_30541862_mainDB");
    

    $userpass = sha1($password);
    $insert = "INSERT INTO users (username, password) VALUES ('$username', '$userpass')";
    $insert2 = "INSERT INTO timestamps(username) VALUES ('$username')";
    $insert3 = "INSERT INTO settings(username) VALUES ('$username')";

    $check_username = mysqli_query($connection, "SELECT username FROM users WHERE username = '$username' ");
    
    if(strlen($username) < 3) {
        print(strlen($username));
        header("location: registerpage.php?error=usernametooshort");
        exit();   
    }
    if(strlen($password) < 5) {
        print(strlen($password));
        header("location: registerpage.php?error=passwordtooshort");
        exit();   
    }

    if($password !== $cpassword) {
        header("location: registerpage.php?error=notmatching");
        exit();   
    }

    if(!preg_match("/^[a-zA-Z0-9]*$/", $username)) {
        header("location: registerpage.php?error=emptyusername");
        exit();
    }

    if(empty($password) || empty($cpassword)) {
        header("location: registerpage.php?error=emptyfield");
        exit();
    }

    if(mysqli_num_rows($check_username) > 0){
        header("location: registerpage.php?error=usernametaken");
        exit();
    }

    if ($connection->query($insert) === TRUE) {
        if($connection->query($insert2) === TRUE) {
            if($connection->query($insert3) === TRUE) {
                header("location: loginpage.php?error=successful");
                exit();
            }
        }
    }
    


    $connection -> close();
} else {
    header("location: registerpage.php");
    exit();
}
?>

    