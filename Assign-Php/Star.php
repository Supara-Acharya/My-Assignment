<?php 
	$n=readLine("command : ");

	readline_add_history($n);
	$empty=$n-1;
	for($i=1;$i<=$n;$i++)
	{
		for($j=1;$j<=$empty;$j++)
		{
			echo " ";
		}
		$empty=$empty-1;
		for($k=0;$k<2*$i-1;$k++)
		{
			echo "*";
		}
		echo "\n";	
	}
	$empty=1;
	for($i=$n-1;$i>=1;$i--)
	{
		for($j=1;$j<=$empty;$j++)
		{
			echo " ";
		}
		$empty=$empty+1;
		for($k=0;$k<2*$i-1;$k++)
		{
			echo "*";
		}
		echo "\n";	
	}
?>


