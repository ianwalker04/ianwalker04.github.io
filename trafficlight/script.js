$(document).ready(function() {
    // var redColor = rgb(255,0,0);
    // var pinkColor = rgb(255, 0, 195);
    // var greenColor = rgb(11, 124, 17);
    // var grey = rgb(51,51,51)
    var state = 0;
    $("#button").click(function() {
        if (state == 0) {
            state = 1;
            $("#circle1").css("background-color","grey");
            $("#circle2").css("background-color","pink");
            $("#circle3").css("background-color","grey");
            console.log("Clicked state 1")
        } else if (state == 1) {
            state = 2;
            $("#circle1").css("background-color","grey");
            $("#circle2").css("background-color","grey");
            $("#circle3").css("background-color","green");
            console.log("Clicked state 1")
        } else if (state == 2){
            state = 0
            $("#circle1").css("background-color","red");
            $("#circle2").css("background-color","grey");
            $("#circle3").css("background-color","grey");
        }
    });
});