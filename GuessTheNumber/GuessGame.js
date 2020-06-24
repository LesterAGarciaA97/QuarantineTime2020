var y = Math.floor(Math.random() * 10 + 1);
var guess = 1;

document.getElementById("submitguess").onclick = function(){
    //Number guessed by user
    var x = document.getElementById("guessField").value;
    if(x == y){
        alert("Congratulations! You guessed it right in "  + guess + " guess");
    }
    else if(x > y){
        guess++;
        alert("Sorry, try a smaller number the next time");
    }
    else{
        guess++;
        alert("Sorry, try a greater number");
    }
}