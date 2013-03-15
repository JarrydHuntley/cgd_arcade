function Dialogport()
{
    var spriteX;
    var spriteY;
    var frameSprite;

    this.initializeObject = function() {
        this.spriteX = 200;
        this.spriteY = 300;
        this.initializeSprite();
	}


    this.initializeSprite = function() {
        this.frameSprite = new Image();
        this.frameSprite.src = "Images/Dialogport.png";
    }

    this.updateObject = function() {
            //TODO PLACEHOLDER
        }

    this.drawSprite = function() {
        if(this.frameSprite.src != "")
        {
            theContext.drawImage(this.frameSprite, this.spriteX, this.spriteY);
        }
    }






}