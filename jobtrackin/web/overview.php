<?php
$headerCode = '
<html>    
     <meta charset="utf-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge">
      <meta name="viewport" content="width=device-width, initial-scale=1">
      <meta name="Personal R&eacute;sum&eacute;/CV site of Matthew Gagn&eacute;" content="">
      <meta name="Matt Gagn&eacute;\'s School Final Project" content="">
      <link rel="shortcut icon" href="img/favicon.ico">  
      <link href="http://fonts.googleapis.com/css?family=Droid+Sans:400,700" rel="stylesheet" type="text/css">
      <!-- Bootstrap core CSS -->
      <link href="./css/bootstrap.css" rel="stylesheet">
      
      <!-- Custom styles for this template -->
      <link href="./justcode.css" rel="stylesheet">
      
      <link href="./fonts/css/fontello.css" rel="stylesheet">
      <link rel="stylesheet" type="text/css" media="all" href="./fancybox/jquery.fancybox.css">
      <link rel="stylesheet" href="./fancybox/helpers/jquery.fancybox-buttons.css?v=1.0.5" type="text/css" media="screen" />
      <link rel="stylesheet" href="./fancybox/helpers/jquery.fancybox-thumbs.css?v=1.0.7" type="text/css" media="screen" />
      <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Yanone+Kaffeesatz:400,700,300,200"/>
      <link rel="stylesheet" type="text/css" media="all" href="./css/panel-slide.css">
      
      <!-- Just for debugging purposes. Don\'t actually copy this line! -->
      <!--[if lt IE 9]><script src="./js/ie8-responsive-file-warning.js"></script><![endif]-->
      
      <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
      <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
      <![endif]-->
      
      <!-- We can put all our jquery here so it\'s easier to find -->
      <script type="text/javascript" src="./fancybox/jquery.fancybox.pack.js?v=2.1.5"></script>
      <script type="text/javascript" src="./fancybox/helpers/jquery.fancybox-buttons.js?v=1.0.5"></script>
      <script type="text/javascript" src="./fancyboxhelpers/jquery.fancybox-media.js?v=1.0.6"></script>
      <script type="text/javascript" src="./fancybox/source/helpers/jquery.fancybox-thumbs.js?v=1.0.7"></script>
      <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
      <script type="text/javascript" src="./js/panel-slide.js"></script>

    <body>
      <div class="navbar navbar-inverse navbar-fixed-top" role="navigation">
        <div class="container">
            <div class="navbar-header">
            </div>
    ';
?>    
 
 
        <!-- Main jumbotron for a primary marketing message or call to action -->
         <div class="jumbotron">
           <div class="container">
                <ul>
                    <li><a href="#">Overview</a></li>
                    <li><a href="#">Activities</a></li>
                    <li><a href="#">Contacts</a></li>
                    <li><a href="#">Call Log</a></li>
                </ul>
             <div class="fly_right">
               <h1 class="green">Matt Gagn&eacute;</h1>
               <h3>Web Developer (Drupal/Php)/Systems Administrator</h3>
               <p> With 26+ years in the technology industry. Experience with Linux/Windows/Mac OS X environments, 5+ Drupal/Php/MySQL,
               Drupal installation, theming and module development, hardware/server/network  maintenance, object oriented
               application development, multi-tiered web application design & development, quality customer service -
               all of which would make me the most versatile member of your team!</p>
               <p><a class="btn btn-primary btn-lg" role="button">Request an Interview &raquo;</a></p>
             </div>
           </div>
             <img alt="Under Construction" src="./img/under-construction_desk.png">
         </div>


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
    