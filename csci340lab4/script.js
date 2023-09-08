$(document).ready(function() {
    $("#clicker").click(function () {
        $.ajax({
            dataType: "json",
            url: "https://catboys.com/api/img",
            success: function(results) {
                $("#catboy").attr("src", results["url"]);
            }
        });
    });
});
