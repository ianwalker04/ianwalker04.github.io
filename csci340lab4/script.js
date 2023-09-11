$(document).ready(function() {
    $("#clicker1").click(function() {
        $.ajax({
            dataType: "json",
            url: "https://random-d.uk/api/v2/random",
            success: function(results) {
                $("#duck").attr("src", results["url"]);
            },
            error: function(xhr,status,error) {
                console.log(error);
            }
        });
    });
});
