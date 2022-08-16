<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PCManager | Download</title>
    <link rel="stylesheet" href="styles/main.css">
    <link rel="stylesheet" href="styles/downloadpage.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="https://kit.fontawesome.com/d48225ec8a.js" crossorigin="anonymous"></script>
</head>
<body style="background: url('images/background-image.png') center top / cover no-repeat;">

    <?php
        include_once 'navbar.php';
    ?>
    
    <div class="mobile-content">
        <h1>All ours apps are currently only available for</h1>
            <ul>
                <li>Windows 7</li>
                <li>Windows 8</li>
                <li>Windows 8.1</li>
                <li>Windows 10</li>
                <li>Windows 11</li>
            </ul>
    </div>

    <div class="download-content">
        <div class="download-frame">
            <h1>PCManager</h1>
            <p>Manage your PC with all the needed tools in one app!</p>
            
            <ul>
                <li class="item-title" style="font-weight: bold;">What can you do with this app?</li>
                <li class="item">Clean your Windows device</li>
                <li class="item">Analyze your network</li>
                <li class="item">Flush your DNS</li>
                <li class="item">Renew or release your IP</li>
            </ul>



            <div class="bottom-center">
                <button class="download-button" onclick="window.open('installers/PCManager Installer.msi')"><i class="fa fa-download"></i> Download</button>
                <br>
                <a class="download-footer-text" href="windows64.php">Only Windows 64-bit devices are supported</a>
            </div>
        </div>
       
        <div class="download-frame">
            <h1>PCSpecs</h1>
            <p>See whats inside your system with all the information!</p>

            <ul>
                <li class="item-title" style="font-weight: bold;">What can you do with this app?</li>
                <li class="item">See all system specifications</li>
                <li class="item">Overview of temperatures & usage</li>
                <li class="item">Use custom Win32 Classes</li>
                <li class="item">Fully customize the appearance</li>
            </ul>

            
            
            <div class="bottom-center">
                <button class="download-button"  onclick="window.open('installers/PCSpecs Installer.msi')"><i class="fa fa-download"></i> Download</button>
                <br>
                <a class="download-footer-text" href="windows64.php">Only Windows 64-bit devices are supported</a>
            </div>
        </div>
    </div>

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

    <script src="index.js"></script>


</body>
</html>