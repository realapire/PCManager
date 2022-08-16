<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PCManager | About Us</title>
    <link rel="stylesheet" href="styles/main.css">
    <link rel="stylesheet" href="styles/aboutus.css">
    <link href="https://unpkg.com/aos@2.3.1/dist/aos.css" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="index.js"></script>
</head>
<body>
    <?php
        include_once 'navbar.php';
    ?>
    <div class="main">
        <div class="title">
            <h1>Founders</h1>
            <p class="names">Meet <span>Andre</span> & <span>Awais.</span></p>
            <span class="scroll">SCROLL DOWN <br> <i class="arrow bottom"></i></span>
        </div>
        <div class="founders" data-aos="zoom-in"> 
            <div class="andre">
                <h2>Andre</h2>
                <p data-aos="fade-down"><i class="fa fa-user" aria-hidden="true"></i> Andre Dubois</p>
                <p data-aos="fade-down"><i class="fa fa-calendar" aria-hidden="true"></i> <script type="text/javascript"> document.write(getAge('2004-10-03')); </script> years old</p>
                <p data-aos="fade-down"><i class="fa fa-briefcase" aria-hidden="true"></i> Programmer</p>
            </div>
            <div class="awais">
                <h2>Awais</h2>
                <p data-aos="fade-down"><i class="fa fa-user" aria-hidden="true"></i> Muhammad Awais</p>
                <p data-aos="fade-down"><i class="fa fa-calendar" aria-hidden="true"></i> <script type="text/javascript"> document.write(getAge('2003-01-15')) </script> years old </p>
                <p data-aos="fade-down"><i class="fa fa-briefcase" aria-hidden="true"></i> Programmer</p>
            </div>
        </div>

    <form class="form" action="web.contactform.php" method="POST">
        <h2>CONTACT US</h2>
        <p type="Name:"><input placeholder="Write your name here.." name="name"></input></p>
        <p type="Email:"><input placeholder="Let us know how to contact you back.." name="email"></input></p>
        <p type="Message:"><input placeholder="What would you like to tell us.." name="message"></input></p>
        <button type="submit" name="submit">Send Message</button>
        <div class="contact-info">
          <span class="fa fa-phone"></span>052 25 14 74
          <span class="fa fa-envelope-o"></span> pcmanager@support.net
        </div>
      </form>

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