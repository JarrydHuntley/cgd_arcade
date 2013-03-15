function FinaleObj()
{
    this.spriteX;
    this.spriteY;
    this.spriteScaleX;
    this.spriteScaleY;
    this.finaleSprite;

    this.finaleTimer;

    easeValue = 0.9; //0.5

    this.initializeObject = function() {
            this.spriteX = -1200;
            this.spriteY = -900;

            this.finaleSprite = new Image();
            this.finaleSprite.src = "sprites/ending3.png";

        if (this.spriteScaleX == undefined){
            this.spriteScaleX = 5000;
        }

        if (this.spriteScaleY == undefined){
            this.spriteScaleY = 3000;
        }
    }




    this.resizeFinaleSprite = function() {
        console.log("repositionSprite  " + this.spriteScaleX + " : " + this.spriteScaleY );

        if(this.spriteScaleX > 800){
            this.spriteScaleX = this.spriteScaleX - 200;
        } else if(this.spriteScaleX < 800) {
            this.spriteScaleX = 800;
        }

        if(this.spriteScaleY > 480){
            this.spriteScaleY = this.spriteScaleY - 120;
        } else if(this.spriteScaleY < 480){
            this.spriteScaleY = 480;
        }

        if(this.spriteX < -1){
            this.spriteX = this.spriteX + 80;
        } else {
            this.spriteX = 0;
        }

        if(this.spriteY < -1){
            this.spriteY = this.spriteY + 50;
        } else {
            this.spriteY = 0;
        }

    }



    this.drawFinaleSprite = function() {
         theContext.save();
	     theContext.drawImage(this.finaleSprite, this.spriteX, this.spriteY, this.spriteScaleX, this.spriteScaleY);
         theContext.restore();
	}

}