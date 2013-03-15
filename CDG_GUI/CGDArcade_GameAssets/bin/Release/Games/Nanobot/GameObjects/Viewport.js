function Viewport()
{
    var spriteX;
    var spriteY;
    var mySprite;
    var frameSprite;

    this.viewPortState = 0;
    this.state0 = "Images/Capacitor.jpg";
    this.state1 = "Images/Chip.jpg";
    this.state2 = "Images/Circuit.jpg";
    this.state3 = "Images/LED.jpg";
    this.state4 = "Images/Resistor.jpg";
    this.state5 = "Images/Silicon.jpg";

    this.initializeObject = function() {
        this.spriteX = 200;
        this.spriteY = 1;
        this.initializeSprite();
	}


    this.initializeSprite = function() {
        this.mySprite = new Image();
        this.frameSprite = new Image();
        this.frameSprite.src = "Images/Dialogport.png";
    }

    this.updateObject = function() {
        //TODO PLACEHOLDER
    }

    this.drawSprite = function() {
        if(this.mySprite.src != "")
        {
   			theContext.drawImage(this.mySprite, this.spriteX, this.spriteY);
            theContext.drawImage(this.frameSprite, this.spriteX, this.spriteY);
        }
   	}


    this.updatePortState = function(newState) {

        this.viewPortState = newState;

        switch (this.viewPortState)
        {
            case 0:
                this.mySprite.src = this.state0;
                if (actionportObject != null) {actionportObject.displayText("You are in a grove of capacitors.");}
                break;
            case 1:
                this.mySprite.src = this.state1;
                if (actionportObject != null) {actionportObject.displayText("You are in the shadows of a computer chip.");}
                break;
            case 2:
                this.mySprite.src = this.state2;
                if (actionportObject != null) {actionportObject.displayText("You are standing on a circuit trace.");}
                break;
            case 3:
                this.mySprite.src = this.state3;
                if (actionportObject != null) {actionportObject.displayText("You are standing in the shadows of an ancient LED.");}
                break;
            case 4:
                this.mySprite.src = this.state4;
                if (actionportObject != null) {actionportObject.displayText("You are in a blighted swamp of resistors.");}
                break;
            case 5:
                this.mySprite.src = this.state5;
                if (actionportObject != null) {actionportObject.displayText("You are in a barren desert of silicon.");}
                break;
        }
   }





}