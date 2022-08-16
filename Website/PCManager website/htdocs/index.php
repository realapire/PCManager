<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>PCManager | Home</title>
    <link rel="stylesheet" href="styles/main.css">
    <link rel="stylesheet" href="styles/homepage.css">
    <link href="https://unpkg.com/aos@2.3.1/dist/aos.css" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="https://kit.fontawesome.com/d48225ec8a.js" crossorigin="anonymous"></script>


</head>
<body>
    <?php
        include_once 'navbar.php';
    ?>
    <section class="submain">
        <div class="content" style="background: url('images/background-image.png') center top / cover no-repeat;">
            <div class="submain-text">                    
                    <h1 class="typewrite" data-period="2000" data-type='[ "Optimize your PC", "Manage my components", "Clean my system", "Open-source projects", "Register an account" ]'>
                        <span class="wrap"></span>
                    </h1>
                <button class="button" id="button" onclick="hpClick()"></button>
            </div>
            <div class="searchbar">
                <i class="fa-solid fa-magnifying-glass"></i>
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
    <script src="index.js"></script>
</body>
</html>
