$(document).ready(function() {
    $('#clicker1').click(function() {
      $.ajax({
        dataType: "json",
        url: "https://random.dog/woof.json",
        success: function(results) {
          console.log(results["url"]);
          if (results["url"].endsWith(".mp4")) {
            $('#dog').attr("src", "Images/dog1.jpg");
          } else {
            $('#dog').attr("src", results["url"]);
          }
        },
        error: function(xhr,status,error) {
          console.log(error);
        }
      });
    });
  });

$(document).ready(function() {
  $('#clicker2').click(function() {
    $.ajax({
      dataType: "jsonp",
      jsonpCallback: "parseQuote",
      url: "https://api.forismatic.com/api/1.0/?method=getQuote&format=jsonp&lang=en&jsonp=parseQuote",
      success: function(results) {
        $("h4").text(results["quoteText"]);
      },
      error: function(xhr,status,error) {
        console.log(error);
      }
    });
  });
});