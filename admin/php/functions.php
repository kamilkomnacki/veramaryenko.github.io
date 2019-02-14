<?php 
error_reporting(E_ERROR);
session_start();

// connect to database
require_once('connect.php');
   
  // username and password sent from form 
  
  $myusername = mysqli_real_escape_string($mysqli,$_POST['login']);
  $mypassword = mysqli_real_escape_string($mysqli,$_POST['haslo']); 
  
  $sql = "SELECT id_user FROM uzytkownicy WHERE nazwa = '$myusername' and haslo = '$mypassword'";
  $result = mysqli_query($mysqli,$sql);
  $row = mysqli_fetch_array($result,MYSQLI_ASSOC);
  $active = $row['active'];
  
  $count = mysqli_num_rows($result);

  // If result matched $myusername and $mypassword, table row must be 1 row
	
  if($count == 1) {
	 $_SESSION['login_user'] = $myusername;
	 
	 header("location: ../dashboard.html");
  }else {
	 $error = "Your Login Name or Password is invalid";
  }
  
?>