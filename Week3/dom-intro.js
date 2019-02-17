(function() {

    function clickHanler(message) {
        console.log('hi....' + message);
    }

    // get a reference to myButton
    let myButton = document.getElementById('myButton');
    myButton.addEventListener('click', function() {clickHanler('hi from life')});
}) ();