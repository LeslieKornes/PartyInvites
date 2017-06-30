
var countDownDate = new Date("Sep 21, 2017 18:30:00").getTime();

var x = setInterval(function() {
var now = new Date().getTime();

 var distance = countDownDate - now;

  var days = Math.floor(distance / (1000 * 60 * 60 * 24));
  var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
  var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
  var seconds = Math.floor((distance % (1000 * 60)) / 1000);

  document.getElementById("countdown").innerHTML = "You only have " + days + " days, " + hours + " hours, "
  + minutes + " minutes, and " + seconds + " seconds left to RSVP!";

  if (distance < 0) {
        clearInterval(x);
    document.getElementById("countdown").innerHTML = "EXPIRED";
  }
}, 1000);
