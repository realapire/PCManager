<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PCManager | Windows 64-bit</title>
    <link rel="stylesheet" href="styles/main.css">
    <link rel="stylesheet" href="styles/windows64.css">

    <style>

    .main {
        color: white;
        margin-left: 30px;
    }

    .main h1 {
        text-decoration: underline;
    }

    </style>
</head>
<body style="background: url('images/background-image.png') center top / cover no-repeat;">
    <?php
        include_once 'navbar.php';
    ?>
    <div class="main">
        <h1>What is Windows 64-bit?</h1>
        <p> The terms 32-bit and 64-bit refer to the way a computer's processor (also called a CPU), handles information. 
            The 64-bit version of Windows handles large amounts of random access memory (RAM) more effectively than a 32-bit system. </p>
        <h1>How to check if you have a 64-bit or 32-bit system?</h1>

        <h2>Windows 11, Windows 10 and Windows 8.1</h2>
        <p>1. Select the <b>Start</b> button, then select <b>Settings</b> > <b>System</b> > <b>About</b>.
        <br>2. At the right, under <b>Device specifications</b>, see <b>System type.</b></p>

        
        <h2>Windows 7</h2>
        <p>1. Select the <b>Start</b> button, right-click <b>Computer</b>, and then select <b>Properties</b>. 
        <br>2. Under <b>System</b>, see the system type.</p>

        <h1>How do I tell if my computer can run a 64-bit version of Windows?</h1>
        <p>To run a 64-bit version of Windows, your computer must have a 64-bit-capable processor.
             Do the following to see if your processor is 64-bit-capable.</p>
        <h2>Windows 11, Windows 10 and Windows 8.1</h2>
        <p>1. Select the <b>Start</b> button, then select <b>Settings</b> > <b>System</b> > <b>About</b>.
        <br>2. At the right, under <b>Device specifications</b>, see <b>System type</b>.</p>
        <h2>Windows 7</h2>
        <p>1. Select the <b>Start</b> button, and then select <b>Control Panel</b>. In the search box, type <b>Performance Information and Tools</b>, and then, in the list of results, select <b>Performance Information Tools</b>.
        <br>2. Select <b>View and print detailed performance and system information</b>.
        <br>3. In the <b>System</b> section, you can see what type of operating system you're currently running under <b>System type</b>, and whether or not you can run a 64-bit version of Windows under 64-bit capable. (In case you're already running a 64-bit version, this won't be listed).</p>

    </div>

</body>
</html>