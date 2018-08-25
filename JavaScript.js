var soundObject = null;

function PlaySound(path) {

    var dropdownlist = document.getElementById("ContentPlaceHolder1_DropDownList1");
    var selectedItem = dropdownlist.options[dropdownlist.selectedIndex].text;

    path = selectedItem + "/" + path;
    soundObject = document.createElement("audio");
    soundObject.setAttribute("src", path);
    soundObject.setAttribute("hidden", true);
    soundObject.setAttribute("autostart", true);
    document.body.appendChild(soundObject);
    soundObject.play();
}



document.onkeydown = function (e) {
    e = e || window.event;
    var key = (e.which || e.keyCode),
    pressed = { 65: 'A', 66: 'B', 67: 'C', 68: 'D', 69: 'E', 70: 'F', 71: 'G', 72: 'H', 73: 'I', 74: 'J', 75: 'K', 76: 'L', 77: 'M', 78: 'N', 79: 'O', 80: 'P', 81: 'Q', 82: 'R', 83: 'S', 84: 'T', 85: 'U', 86: 'V', 87: 'W', 88: 'X', 89: 'Y', 90: 'Z', 49: 'ContentPlaceHolder1_btn_Rec1', 50: 'ContentPlaceHolder1_btn_Rec2', 51: 'ContentPlaceHolder1_btn_Rec3', 52: 'ContentPlaceHolder1_btn_Rec4', 53: 'ContentPlaceHolder1_btn_Rec5', 54: 'ContentPlaceHolder1_btn_Rec6', 55: 'ContentPlaceHolder1_btn_Rec7', 56: 'ContentPlaceHolder1_btn_Rec8', 57: 'ContentPlaceHolder1_btn_Rec9' };

    if (typeof pressed[key] === 'undefined')
        return;

    if(key>=49 && key<=57)
        var button = document.getElementById(pressed[key]);
    else
        var button = document.getElementById(pressed[key]);

    button.click();
    button.className = 'button activate';
    setTimeout(function () { button.className = 'button'; }, 100);
}

//For side Nav Bar
var flag = 0;

function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
    document.getElementById("main").style.marginLeft = "250px";
    flag = 1;
}

function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
    document.getElementById("main").style.marginLeft = "0";
    flag = 0;
}

function toggleNav() {
    if (flag == 0)
        openNav();
    else
        closeNav();
}






// Establish all variables that your Analyser will use
var canvas, ctx, source, context, analyser, fbc_array, bars, bar_x, bar_width, bar_height;

// Initialize the MP3 player after the page loads all of its HTML into the window
window.addEventListener("load", initMp3Player, false);

function initMp3Player() {
    var audio = document.getElementById('audio');
    context = new window.AudioContext() // AudioContext object instance
    analyser = context.createAnalyser(); // AnalyserNode method
    canvas = document.getElementById('canvas');

    ctx = canvas.getContext('2d');
    //ctx.rotate(360 * Math.PI / 180);
    // Re-route audio playback into the processing graph of the AudioContext
    source = context.createMediaElementSource(audio);
    source.connect(analyser);
    analyser.connect(context.destination);
    frameLooper();
}


// frameLooper() animates any style of graphics you wish to the audio frequency
// Looping at the default frame rate that the browser provides(approx. 60 FPS)
function frameLooper() {

    window.requestAnimationFrame(frameLooper);
    fbc_array = new Uint8Array(analyser.frequencyBinCount);
    analyser.getByteFrequencyData(fbc_array);
    ctx.clearRect(0, 0, canvas.width, canvas.height); // Clear the canvas
    ctx.fillStyle = '#008CBA;'; // Color of the bars

    bars = 150;

    for (var i = 0; i < bars; i++) {
        bar_x = (i * 4);
        bar_width = 3;
        bar_height = -(fbc_array[i] / 6);
        //ctx.rotate(360);
        ctx.fillRect(bar_x, canvas.height, bar_width, bar_height); //( x, y, width, height )
    }
}
