
<?php ?>
<!DOCTYPE HTML>
<html>
<head>
<style>
</style>
</head>
<body>
<?php
  $sortedArrs = array();
  $labelM = "";
  $invalidErr = false;
  if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $numVal = $_POST["numbers"];
    $sortType = $_POST["sortT"];
    $invalidErr = false;
        if(empty($numVal) || !preg_match("/^[1-9 ][ 0-9]*$/",$numVal) )  {
          $invalidErr = true;
        }
        else {
          $labelM = "";
          $invalidErr = false;
          $numArrs = explode(" ",$numVal);
            switch ($sortType) {
                case 0:
                    $sortedArrs = bubbleSort($numArrs);
                    $labelM = "sorted using bubble sort <br> RESULT:";
                    break;
                case 1:
                    $sortedArrs = selectionSort($numArrs);
                    $labelM = "sorted using select sort <br> RESULT:";
                    break;
                case 2:
                    $sortedArrs = quickSort($numArrs);
                    $labelM = "sorted using quick sort <br> RESULT:";
                    break;
                default:
                  sort($sortedArrs);
                  $labelM = "sorted using default php sort <br> RESULT:";
            }
        }
    }

function quickSort($arr){
    	$loe = $gt = array();
      	if(count($arr) < 2){
      		return $arr;
      	}
    	$p_key = key($arr);
    	$p = array_shift($arr);
      	foreach($arr as $val){
      		if($val <= $p){
      			$loe[] = $val;
      		}elseif ($val > $p){
      			$gt[] = $val;
      		}
      	}
    	return array_merge(quicksort($loe),array($p_key=>$p),quicksort($gt));
}

function selectionSort(array $arr) {
      $n=count($arr);
      for($i=0; $i<$n-1; $i++)
      {
          $nextSwap=$i;
          for($j=$i+1; $j<$n; $j++)
          {
              if( $arr[$j]<$arr[$nextSwap] )
              {
                  $nextSwap=$j;
              }
          }
          $temp=$arr[$i];
          $arr[$i]=$arr[$nextSwap];
          $arr[$nextSwap]=$temp;
      }
      return $arr;
}

function bubbleSort(array $arr) {
      $n =sizeof($arr);
      for($i =1; $i < $n; $i++) {
          $flag =false;
          for($j = $n -1; $j >= $i; $j--) {
              if($arr[$j-1]> $arr[$j]) {
                  $tmp = $arr[$j -1];
                  $arr[$j -1]= $arr[$j];
                  $arr[$j]= $tmp;
                  $flag =true;
              }
          }
          if(!$flag) {
              break;
          }
      }
      return $arr;
}


?>

<form method="post" action="<?=$_SERVER['REQUEST_URI']?>">
  <h1>INPUT VALUE:</h1>
  <input type="text" name="numbers" value=""><?php if($invalidErr==true){echo "<h3 style='color:red;'>*INVALID INPUT* Only Numbers with spaces</h3>";}?>
  <input type="radio" name="sortT" value="0">Bubble Sort
  <input type="radio" name="sortT" value="1" checked>Selection Sort
  <input type="radio" name="sortT" value="2">Quick Sort
  <input type="submit" name="submit" value="Submit">
</form>

<?php
   if(is_array($sortedArrs))
   {
     echo $labelM;
     foreach($sortedArrs as $value) {
       echo $value . " ";
     }
   }
?>

</body>
</html>
