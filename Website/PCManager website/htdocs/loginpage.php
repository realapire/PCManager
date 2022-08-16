<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PCManager | Login</title>
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
                <form action="web.login.php" method="POST">
                    <h3>Login</h3>
                    <label for="username">Username</label>
                    <input type="text" placeholder="Username" name="username" id="username">
                    <label for="password">Password</label>
                    <input type="password" placeholder="Password" name="password" id="password">

                    <?php
                    
                    if(isset($_GET['error'])) {
                        $errorMessage = $_GET['error'];
                        
                        if($errorMessage === "successful") {
                            echo "<div class='successful'>";
                            echo "<p>Account created successfully</p>";
                            echo "</div>";
                        }
                        else {
                        echo "<div class='error'>";
                        
                        switch($errorMessage) {
                            case "notfound":
                                echo "<p>Account not found</p>";
                                break;
                        }

                        echo "</div>";
                        }
                    }
                    
                    ?>

                    <input type="submit" name="submit" class="button" value="Log In">
                    <button type="button" class="button" onclick="location.href='registerpage.php'" style="margin:10px 0 0 0;background-color: rgb(41 57 94);color: white;">Register</button>
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
    ?>


    <script src="https://unpkg.com/aos@2.3.1/dist/aos.js"></script>
    <script>
        AOS.init();
    </script>

</body>
</html>