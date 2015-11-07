//selecting all the checkboxex in the page and assigning them in an array.
var nodeList = document.querySelectorAll("input[type=checkbox]");
//loop through all the checkboxex
for(var i = 0; i < nodeList.length; i++) {
	//if the id of a checkbox contains the word "ab" continue
	if(nodeList[i].id.indexOf("ab") > -1)
	{
		//replace the word in the ab to marks and assign the value to temp
		var temp = nodeList[i].id.replace("ab","marks");
		//get the value of the textselected text box using the ID that we have on temp
		var valOfTxtBox = document.getElementById(temp).value;
		//if the value is null or blank check the textbox
		if(valOfTxtBox == null || valOfTxtBox == "") {
			nodeList[i].checked = true;
		}
	}	
}

