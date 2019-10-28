<?php
	$con = mysqli_connect('19.168.0.101', 'Ilya', '', 'unityaccess');
	
	//check that connection happened
	if (mysqli_connect_error())
	{
		echo "1 : connection failed"; // error code #1 = connection failed
		exit();
	}
	
	$username = $_POST["name"];
	$password = $_POST["password"];

	//check if name exists
	$namecheckquery = "SELECT username FROM players WHERE username='" . $username . "';";

	$namecheck = mysqli_query($con, $namecheckquery) or die("2: name check query failed"); // error code #2 = name check query failed

	if (mysqli_num_rows($namecheck)>0)
	{
		echo "3: name already exist" ; // error code #3 = name exist, cannot register
		exit();
	}

	
	//add user to table
	//convert player password to hash and salt in database, don't want to store data ini plaintext to avoid stolen data
	
	$salt = "\$5\$rounds=5000\$" . "steamedhams" . $username . "\$";
	$hash = crypt($password, $salt);

	$insertuserquery = "INSERT INTO players (username, hash, salt) VALUES ('" . $username . "', '" . $hash . "', '" . $salt . "');";
	mysqli_query($con, $insertuserquery) or die ("4 : insert player query failed"); // error code #4 : insert query failed

	echo ("0");
	
	
?>