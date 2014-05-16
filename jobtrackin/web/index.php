<?php

    header("Cache-Control: no-store, no-cache, must-revalidate, max-age=0");
    header("Cache-Control: post-check=0, pre-check=0", false);
    header("Pragma: no-cache");
    //NOTE: Normally I would NEVER do this but there just wasn't time to complete the "session" code so...
    global $dbconn, $uUserId, $uUser, $uFirstName, $uLastName, $uSocLastFour, $uEmail, $uPhotoPath, $uResumePath, $uPermission;

    if (isset($_POST['submit']) && $_POST['submit']==="Login") {
        ini_set('display_errors', 1);
        error_reporting(E_ALL);

        session_start();
        
        $username = $_POST['username'];
        $password = $_POST['password'];
        
        include dirname(__FILE__) . '/settings.php';
        
        $dbconn = new mysqli($host, $serveruser, $svrpass, $defaultdb);

        if ($dbconn->connect_errno) {
            die("Problem connecting to the database, The error returned is: " .
                $dbconn->connect_errno . ": " . $dbconn->connect_error);
        }//else echo "<h4>DB Connection established....</h4>";

        $usrQryStmt = "SELECT userID, username, firstName, lastName, socLastFour, email, photoPath, resumePath, permission
                        FROM jobUsers
                        WHERE username =  '" . $username . "'";
            if ($result = mysqli_query($dbconn, $usrQryStmt)) {
                while ($myrow = $result->fetch_array(MYSQLI_NUM)) {//SHOULD only be one record.
                    $uUserId = $myrow[0];
                    $uUser = $myrow[1];
                    $uFirstName = $myrow[2];
                    $uLastName = $myrow[3];
                    $uSocLastFour = $myrow[4];
                    $uEmail = $myrow[5];
                    $uPhotoPath = $myrow[6];
                    $uResumePath = $myrow[7];
                    $uPermission = $myrow[8];
                    //echo '<h4>Below is the raw data from $myrow: </h4>';
                    //print_r($myrow);
                    header('Location: ./overview.php');
                }
            }else echo '<h4>Mysqli_query failed! The error is: ' . $dbconn->connect_errno . ': ' . mysqli_error($dbconn) . '</h4>';            
     }else{
        if (isset($_POST['submit']) && $_POST['submit']==="Login") {
            echo "<h4>Form shows as submitted but is obviously still having a problem...</h4><br>";
        }


    }//else echo "<h4>Either Username and password were not entered...</h4>";
?>


<html>    
    <head>
        <title>Matt Gagn&eacute;'s School Final Project</title>
        <link href="./justcode.css" rel="stylesheet">        
    </head>
    
    <body>
        <form style="width: 15%;" action="./index.php" method="post">
            <fieldset>
                <legend>Enter Login Information:</legend>
                Username: *&nbsp;<input type="text" name="username"><br>
                Password: *&nbsp;&nbsp;<input type="password" name="password"><br>
                <input type="submit" style="float: right; margin: 5% 0 0 0;" name="submit" value="Login">
            </fieldset>
        </form>
<?php   
    $footerCode = '
      <hr>

      <footer class="footer">
        <p class="pull-left">2014 &copy; It\'s Just Code</p>
        <p class="pull-right"><a href="#myModal" role="button" data-toggle="modal"> <i class="icon-mail"></i> CONTACT</a></p>        
      </footer>
    </div> <!-- /container -->


    <!-- Contact form in Modal -->
    <!-- Modal -->
    <div id="myModal" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">?</button>
            <h3 id="myModalLabel"><i class="icon-mail"></i> Contact Me</h3>
        </div>
        <div class="modal-body">
            <form>
                <input type="text" placeholder="Your Name">
                <input type="text" placeholder="Your Email">
                <input type="text" placeholder="Website (Optional)">
                <textarea rows="3" style="width:80%"></textarea>
                <br/>
                <button type="submit" class="btn btn-large"><i class="icon-paper-plane"></i> SUBMIT</button>
            </form>
        </div>
    </div>

   <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
    <script src="./js/bootstrap.min.js"></script>

  </body>
</html>
';

echo $footerCode;    
    