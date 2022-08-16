<?php

if(isset($_POST['submit'])) {
    $name = $_POST['name'];
    $mailFrom = $_POST['email'];
    $message = $_POST['message'];

    $mailTo = "andred@programmer.net";
    $headers = "From: ".$mailFrom;
    $txt = "You have received an email from ".$name.".\n\n".$message;

    if(mail($mailTo, $subject, $txt, $headers)) {
        header("Location: index.php");
    }
}
?>