//  Convert an epoch to human readable date:

function convertEpochToHuman(){
    var myDate = new Date( your epoch date *1000);
    document.write(myDate.toGMTString()+"<br>"+myDate.toLocaleString());
}



//  The example above gives the following output (with epoch date 1):
//  Thu, 01 Jan 1970 00:00:01 GMT
//  Wed Dec 31 1969 19:00:01 GMT-0500 (Eastern Standard Time)
//  You can also use getFullYear, getMonth, getDay etc. See documentation below.



//  Convert human readable dates to epoch:

function convertHumanToEpoch(){
    var myDate = new Date("July 1, 1978 02:30:00"); // Your timezone!
    var myEpoch = myDate.getTime()/1000.0;
    document.write(myEpoch);
}

//  The example above gives the following output:
//  268122600