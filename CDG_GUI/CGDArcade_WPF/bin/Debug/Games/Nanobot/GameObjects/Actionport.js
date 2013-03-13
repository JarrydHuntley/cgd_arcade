function Actionport()
{
    var spriteX;
    var spriteY;
    var frameSprite;
    var textArray;
    var arrayCounter;


    this.initializeObject = function() {
        this.spriteX = 0;
        this.spriteY = 200;
        this.initializeSprite();
        this.textArray = new Array();
        this.clearTextArray();
	}


    this.initializeSprite = function() {
        this.frameSprite = new Image();
        this.frameSprite.src = "Images/Actionport.png";
    }

    this.updateObject = function() {
            //TODO PLACEHOLDER
        }

    this.drawSprite = function() {
        if(this.frameSprite.src != "")
        {
            theContext.fillStyle = '#000000';
            theContext.fillRect (220,320, 560, 260);
            //theContext.fillRect (200,300, 800, 600);

            theContext.drawImage(this.frameSprite, this.spriteX, this.spriteY);

            theContext.font= "22px Calibri";
            theContext.fillStyle = "#3E8043";

            theContext.fillText(this.textArray[0], 224,334);
            theContext.fillText(this.textArray[1], 224,354);
            theContext.fillText(this.textArray[2], 224,374);
            theContext.fillText(this.textArray[3], 224,394);
            theContext.fillText(this.textArray[4], 224,414);
            theContext.fillText(this.textArray[5], 224,434);
            theContext.fillText(this.textArray[6], 224,454);
            theContext.fillText(this.textArray[7], 224,474);
            theContext.fillText(this.textArray[8], 224,494);
            theContext.fillText(this.textArray[9], 224,514);
            theContext.fillText(this.textArray[10], 224,534);
            theContext.fillText(this.textArray[11], 224,554);
            theContext.fillText(this.textArray[12], 224,574);
        }
    }

    this.clearTextArray = function() {

        this.arrayCounter = 0;
        for (var i = 0; i <= 14; i++)
        {
            this.textArray[i] = "";
        }
    }

    this.displayText = function(textString){

        for (var i = 0; i < 13; i++)
        {
            this.textArray[i] = this.textArray[i + 1];
        }

        this.textArray[12] = textString;
    }










}