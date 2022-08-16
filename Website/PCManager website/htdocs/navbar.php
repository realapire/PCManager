<?php
    session_start();
?>

<header>
        <div class="flex container">
            <a id="logo" href="index.php">PCManager</a>
            <nav>
                <ul id="nav-menu">
                    <li><a href="downloadpage.php">Download</a></li>
                    <li><a href="aboutuspage.php">About us</a></li>
                    <li><a href="https://pcmanager.tawk.help">Support</a></li>
                    <?php
                        if(isset($_SESSION["username"])) {
                            echo "<li><a href='profile.php'>Profile</a></li>";
                            echo "<li><a href='web.logout.php' class='loginbutton'>Logout</a></li>";
                        } else {
                            echo "<li><a href='loginpage.php' class='loginbutton'>Login</a></li>";
                        }
                    ?>
                    <li id="close-flyout"><span class="fas fa-times"></span></li>
                </ul>
            </nav>
            <div class="mobile-navigation">
                <i class="fa fa-question-circle" aria-hidden="true" onclick="location.href ='https://pcmanager.tawk.help'"></i>
            </div>
        </div>
</header>
