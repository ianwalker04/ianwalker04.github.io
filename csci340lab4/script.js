$(document).ready(function() {
    console.log("Loaded");
    $("#clicker1").click(function() {
        $.ajax({
            dataType: "json",
            url: "https://random-d.uk/api/v2/random",
            success: function(results) {
                $("#duck").attr("src", results["url"]);
                console.log("Success");
                console.log(results);
            },
            error: function(xhr,status,error) {
                console.log(error);
            }
        });
    });
});
