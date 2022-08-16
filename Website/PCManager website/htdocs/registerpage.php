<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PCManager | Register</title>
    <link rel="stylesheet" href="styles/main.css">
    <link rel="stylesheet" href="styles/loginpage.css">
    <script src="https://kit.fontawesome.com/d48225ec8a.js" crossorigin="anonymous"></script>
    <style media="screen">
        form, input, label
        form:before, input:before, label:before,
        form:after, input:after, label:after {
            margin: 0;
            box-sizing: border-box;
  } </style>
</head>
<body>
    <?php
        include_once 'navbar.php';
    ?>

    <section class="submain">
        <div class="content" style="background: url('images/background-image.png') center top / cover no-repeat;">
            <div class="submain-text">
                <form action="web.signup.php" method="POST">
                    <h3>Register</h3>
                    <label for="username">Username</label>
                    <input type="text" placeholder="Username" name="username" id="username" autocomplete=off required>
                    <label for="password">Password</label>
                    <input type="password" placeholder="Password" name="password" id="password" autocomplete=off required>
                    <label for="password">Confirm Password</label>
                    <input type="password" placeholder="Password" name="cpassword" id="confirmpassword" autocomplete=off required>

                    <?php
                    
                    
                    if(isset($_GET['error'])){
                        $errorMessage = $_GET['error'];

                        echo "<div class='error'>";

                        switch($errorMessage) {
                            case "usernametooshort":
                                echo "<p>Username is too short</p>";
                                break;
                            case "passwordtooshort":
                                echo "<p>Password is too short</p>";
                                break;
                            case "notmatching":
                                echo "<p>Passwords do not match</p>";
                                break;
                            case "emptyfield":
                                echo "<p>Please fill in all fields</p>";
                                break;
                            case "usernametaken":
                                echo "<p>Username has been taken</p>";
                                break;
                        }

                        echo "</div>";

                    }

                    ?>
                    <input type="submit" name="submit" class="button" value="Register">
                    <button type="button" class="button" onclick="location.href='loginpage.php'" style="margin:10px 0 0 0;background-color: rgb(41 57 94);color: white;">Log In</button>
                </form>
            </div>
        </div>
    </section>

    <script type="text/javascript">
        var Tawk_API=Tawk_API||{}, Tawk_LoadStart=new Date();
        (function(){
        var s1=document.createElement("script"),s0=document.getElementsByTagName("script")[0];
        s1.async=true;
        s1.src='https://embed.tawk.to/61aecef6c82c976b71c01991/1fm9dgtv1';
        s1.charset='UTF-8';
        s1.setAttribute('crossorigin','*');
        s0.parentNode.insertBefore(s1,s0);
        })();
    </script>

    <?php
        include_once 'footer.php';
        echo '<script type="text/javascript" src="index.js"></script>';
    ?>


    <script src="https://unpkg.com/aos@2.3.1/dist/aos.js"></script>
    <script>
        AOS.init();
    </script>

</body>
</html>