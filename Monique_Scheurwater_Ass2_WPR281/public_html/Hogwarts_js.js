/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 * MONIQUE SCHEURWATER
 */

//FOR TESTING PURPOSES ONLY. TO TEST UNCOMMENT LINE 8 AND COMMENT OUT LINE 9
//var start = new Date("08/05/2019 09:00:55");
var start = new Date(Date.now()); //gets todays date
var seconds = start.getSeconds(); //gets the second that the webpage is opened
console.log(seconds); //writes the seconds to the console

window.onload = function(){ //to make sure that the functions load
    sec(); //calls my function called sec()
};

function Draco() { //a function to generate a picture
  var x = document.createElement("IMG"); //creates a new element of type image
  x.setAttribute("src", "draco.png"); //sets what image must be displayed
  x.setAttribute("id","draco"); //sets the name of the image
  x.setAttribute("width", "650"); //sets the width of the image
  x.setAttribute("height", "600"); //sets the height of the image
  x.setAttribute("alt", "Draco Malfoy, Slytherin"); //sets what it should 
  //display if image doesn't exist
  document.body.appendChild(x); //sets where the image must display
}

function DracoOld() { //a function to generate a picture
  var x = document.createElement("IMG"); //creates a new element of type image
  x.setAttribute("src", "draco2.png"); //sets what image must be displayed
  x.setAttribute("id","dracoOld"); //sets the name of the image
  x.setAttribute("width", "500"); //sets the width of the image
  x.setAttribute("height", "650"); //sets the height of the image
  x.setAttribute("alt", "Draco Malfoy, Slytherin");//sets what it should 
  //display if image doesn't exist
  document.body.appendChild(x); //sets where the image must display
}

function DracoM() { //a function to generate a picture
  var x = document.createElement("IMG"); //creates a new element of type image
  x.setAttribute("src", "draco1.png"); //sets what image must be displayed
  x.setAttribute("id","dracoM"); //sets the name of the image
  x.setAttribute("width", "500"); //sets the width of the image
  x.setAttribute("height", "580"); //sets the height of the image
  x.setAttribute("alt", "Draco Malfoy, Slytherin"); //sets what it should 
  //display if image doesn't exist
  document.body.appendChild(x); //sets where the image must display
}

function Harry() { //a function to generate a picture
  document.getElementById('gryffindor').src = 'harry.png'; //sets what image 
  //must be displayed
  document.getElementById('gryffindor').width = 400; //sets the width of the
  // image
  document.getElementById('gryffindor').height = 650; //sets the height of the 
  //image
  document.getElementById('gryffindor').alt = 'Harry Potter, Gryffindor'; //sets 
  //what it should display if image doesn't exist
}

function Hermoine() { //a function to generate a picture  
  document.getElementById('gryffindor').src = 'hermfull.png'; //sets what image
  // must be displayed
  document.getElementById('gryffindor').width = 500; //sets the width of the 
  //image
  document.getElementById('gryffindor').height = 700; //sets the height of the 
  //image
  document.getElementById('gryffindor').alt = 'Hermione Granger, Gryffindor'; 
  //sets what it should display if image doesn't exist
}

function Ron() { //a function to generate a picture
  document.getElementById('gryffindor').src = 'ron.png'; //sets what image must 
  //be displayed
  document.getElementById('gryffindor').width = 700; //sets the width of the 
  //image
  document.getElementById('gryffindor').height = 500; //sets the height of the 
  //image
  document.getElementById('gryffindor').alt = 'Ron Weasley, Gryffindor'; //sets 
  //what it should display if image doesn't exist
}

function Sly() { //a function to generate a picture
  var x = document.createElement("IMG"); //creates a new element of type image
  x.setAttribute("src", "slycrest.png"); //sets what image must be displayed
  x.setAttribute("id","sly"); //sets the name of the image
  x.setAttribute("width", "500"); //sets the width of the image
  x.setAttribute("height", "500"); //sets the height of the image
  x.setAttribute("alt", "Slytherin Crest, Slytherin"); //sets what it should 
  //display if image doesn't exist
  document.body.appendChild(x); //sets where the image must display
}

function Gryff() { //a function to generate a picture
    document.getElementById('logo').src = 'gryffcrest.png'; //sets what image must 
    //be displayed
    document.getElementById('logo').width = 450; //sets the width of the 
  //image
    document.getElementById('logo').height = 450; //sets the height of the 
  //image
    document.getElementById('logo').alt = 'Gryffindor Crest, Gryffindor'; //sets 
  //what it should display if image doesn't exist
}

function sec() //a function to check the seconds
{
    if ((seconds <= 59) && (seconds >=49)) { //checks if the seconds are 
        // between 59 and 49
        document.getElementById("header").style.color = "#990000"; //sets the 
        //header color to a goldish color
        document.getElementById("bod").style.backgroundColor = "#DAA520"; //sets 
        //the background color to a redish color
        document.getElementById("header").innerHTML = "Gryffindor wins again."; 
        //sets what message should be displayed in the header
        Hermoine(); //calls function to display image
        Gryff(); //calls method to display image
    } else if ((seconds < 49) && (seconds >= 39)) { //checks if seconds are 
        //between 49 and 39
        document.getElementById("header").style.color = "#990000"; //sets the 
        //header color to a goldish color
        document.getElementById("bod").style.backgroundColor = "#DAA520"; //sets 
        //the background color to a redish color
        document.getElementById("header").innerHTML = "Gryffindor wins again.";
        //sets what message should be displayed in the header
        Harry(); //calls function to display image
        Gryff(); //calls function to display image
    } else if ((seconds < 39) && (seconds >= 30)) {
        document.getElementById("header").style.color = "#990000"; //checks if 
        //the seconds are between 39 and 30
        document.getElementById("bod").style.backgroundColor = "#DAA520"; //sets 
        //the header color to a goldish color
        document.getElementById("header").innerHTML = "Gryffindor wins again.";
        //sets what message should be displayed in the header
        Ron(); //calls function to display image
        Gryff(); //calls function to display image
    } else if ((seconds < 30) && (seconds >= 19)) {
        document.getElementById("bod").style.backgroundColor = "#124e22"; //sets
        // the background to a greenish color
        document.getElementById("header").style.color = "#A9A9A9"; //Sets the 
        //header color to a silwerish color
        document.getElementById("header").innerHTML = "Slytherin Rules. <br/> Gryffindor drools.";
        //sets what message should be displayed in the header
        DracoOld(); //calls function to display image
        Sly(); //calls function to display image
    } else if ((seconds < 19) && (seconds >= 9)) {
        document.getElementById("bod").style.backgroundColor = "#124e22"; //sets
        // the background to a greenish color
        document.getElementById("header").style.color = "#A9A9A9"; //Sets the 
        //header color to a silwerish color
        document.getElementById("header").innerHTML = "Slytherin Rules. <br/> Gryffindor drools.";
        //sets what message should be displayed in the header
        DracoM(); //calls function to display image
        Sly(); //calls function to display image
    } else {
        document.getElementById("bod").style.backgroundColor = "#124e22"; //sets
        // the background to a greenish color
        document.getElementById("header").style.color = "#A9A9A9";//Sets the 
        //header color to a silwerish color
        document.getElementById("header").innerHTML = "Slytherin Rules. <br/> Gryffindor drools.";
        //sets what message should be displayed in the header
        Draco(); //calls function to display image
        Sly(); //calls function to display image
    }
  
}

