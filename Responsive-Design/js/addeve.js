$( "#searchCode" ).focus(function() {
  if($("#searchCode").val()=="Enter AE Code")
  {
      $("#searchCode").val("");
  }
});

$( "#searchCode" ).focusout(function() {
  if($("#searchCode").val()=="")
  {
      $("#searchCode").val("Enter AE Code");
  }
});


$( "#translateCode" ).focus(function() {
  if($("#translateCode").val()=="Enter AE Code")
  {
      $("#translateCode").val("");
  }
});

$( "#translateCode" ).focusout(function() {
  if($("#translateCode").val()=="")
  {
      $("#translateCode").val("Enter AE Code");
  }
});
