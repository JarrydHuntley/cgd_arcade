function PlayerObj()
{
    this.playerX;
    this.playerY;
    this.oldPlayerX;
    this.oldPlayerY;

    this.spriteX;
    this.spriteY;
    this.moveSpriteToX;
    this.moveSpriteToY;
    this.moveSpriteSpeed = 20; //must be a integer divisible of 40
    this.moveSpriteSpeedIncrement = 10;

    easeValue = 0.3; //0.5


    this.playerState = 0;  // 0 = free, 1 = locked
    this.state0 = "sprites/white_40x40.png";    //white
	this.mySprite;
    this.visible = true;



    this.initializeObject = function(playerx, playery) {
		this.playerX = playerx;
        this.playerY = playery;
        this.spriteX = playerx * 40;
        this.spriteY = playery * 40;
        this.initializeSprite();
	}



	this.initializeSprite = function() {
		this.mySprite = new Image();
        this.mySprite.src = this.state0;
	}

	this.drawSprite = function() {
		if (this.visible) {
			theContext.drawImage(this.mySprite, this.spriteX, this.spriteY)
		}
	}

    this.setNewPlayerTiles = function(playerx, playery) {
    	this.oldPlayerX = playerx;
        this.oldPlayerY = playery;

        this.playerX = playerx;
        this.playerY = playery;
    }


    this.updatePlayer = function() {
       // console.log("updateplayer");

        if (this.playerState == 0) {
            // UP
            if (keyPressTrack == 38) {
                //console.log("updateplayer UP KEY");
                if((window.mazeArray[this.playerX][this.playerY - 1].tileState == 0) || (window.mazeArray[this.playerX][this.playerY - 1].tileState == 3)){
                    //console.log("TILESTATE " + window.mazeArray[this.playerX][(this.playerY - 1)].tileState)
                    //console.log("updateplayer EMPTY MAZE");
                    this.playerState = 1;
                    this.setNewPlayerTiles(this.playerX,(this.playerY - 1));
                    this.setMoveToCoords();
                }
            }
            // LEFT
            if (keyPressTrack == 37) {
                //console.log("updateplayer LEFT KEY");
                if((window.mazeArray[this.playerX -1][this.playerY].tileState == 0) || (window.mazeArray[this.playerX -1][this.playerY].tileState == 3)){
                    //console.log("updateplayer EMPTY MAZE");
                    this.playerState = 1;
                    this.setNewPlayerTiles((this.playerX - 1), this.playerY);
                    this.setMoveToCoords();
                }
            }
            // DOWN
            if (keyPressTrack == 40) {
                //console.log("updateplayer DOWN KEY");
                if((window.mazeArray[this.playerX][this.playerY + 1].tileState == 0) || (window.mazeArray[this.playerX][this.playerY + 1].tileState == 3)){
                    //console.log("updateplayer EMPTY MAZE");
                    this.playerState = 1;
                    this.setNewPlayerTiles(this.playerX,(this.playerY + 1));
                    this.setMoveToCoords();
                }
            }
            // RIGHT
            if (keyPressTrack == 39) {
                //console.log("updateplayer RIGHT KEY");
                if((window.mazeArray[this.playerX + 1][this.playerY].tileState == 0) || (window.mazeArray[this.playerX + 1][this.playerY].tileState == 3)){
                    //console.log("updateplayer EMPTY MAZE");
                    this.playerState = 1;
                    this.setNewPlayerTiles((this.playerX + 1), this.playerY);
                    this.setMoveToCoords();
                }
            }
            keyPressTrack = 0;

        } else {
            
            keyPressTrack = 0;
            this.movePlayerSprite();
        }

            // up    38
            // left  37
            // down  40
            // right 39
            // space 32
    }

    this.setMoveToCoords = function() {
        this.moveSpriteSpeed = 20;

        this.moveSpriteToX = mazeArray[this.playerX][this.playerY].spriteX;
        this.moveSpriteToY = mazeArray[this.playerX][this.playerY].spriteY;
    }


    this.movePlayerSprite = function() {
        //console.log("movePlayerSprite");

        mazeArray[this.oldPlayerX][this.oldPlayerY].setForRefresh();

        var dx = this.moveSpriteToX - this.spriteX;
        var dy = this.moveSpriteToY - this.spriteY;

        //var velocityX = dx * easeValue;
        //var velocityY = dy * easeValue;

        var velocityX = dx;
        var velocityY = dy;

        this.spriteX += velocityX;
        this.spriteY += velocityY;


        if((dx > 0) || (dy > 0)) {
            if (velocityX < 1){
                this.spriteX = this.moveSpriteToX;
            }
            if (velocityY < 1){
                this.spriteY = this.moveSpriteToY;
            }
        }

        if((dx < 0) || (dy < 0)) {
            if (velocityX > -1){
                this.spriteX = this.moveSpriteToX;
            }
            if (velocityY > -1){
                this.spriteY = this.moveSpriteToY;
            }
        }





        //console.log("VEL " + velocityX + ":" + velocityY + "  " + dx + ":" + dy);
        //console.log("SPR " + this.spriteX + ":" + this.spriteY + "  " + this.moveSpriteToX + ":" + this.moveSpriteToY)

        if ((this.spriteX == this.moveSpriteToX) && (this.spriteY == this.moveSpriteToY)) {
            this.playerState = 0;
        }
    }





	//this.setCoords = function(xCoord, yCoord) {
	//	this.x = xCoord;
	//	this.y = yCoord;
	//}



	this.setInvisible = function() {
		this.visible = false;
	}

	this.setVisible = function() {
		this.visible = true;
	}


	this.createEvents = function() {

		if (touchEnabled) {
			//theCanvasEventHandler.AddCustomEventHandler("GAME_ACTIVE", "touchstart", "0", this, this.mySprite, gamePath.startMouseGesture);
			//theCanvasEventHandler.AddCustomEventHandler("GAME_ACTIVE_TrackMoveEvents", "touchmove", "0", bckImage, bckImage.mySprite, gamePath.processEventCoords);
			//theCanvasEventHandler.AddCustomEventHandler("GAME_ACTIVE_TrackMoveEvents", "touchend", "0", bckImage, bckImage.mySprite, gamePath.endMouseGesture);
		} else {
			//theCanvasEventHandler.AddCustomEventHandler("GAME_ACTIVE", "mousedown", "0", this, this.mySprite, gamePath.startMouseGesture);
			//theCanvasEventHandler.AddCustomEventHandler("GAME_ACTIVE_TrackMoveEvents", "mousemove", "0", bckImage, bckImage.mySprite, gamePath.processEventCoords);
			//theCanvasEventHandler.AddCustomEventHandler("GAME_ACTIVE_TrackMoveEvents", "mouseup", "0", bckImage, bckImage.mySprite, gamePath.endMouseGesture);
		}


	}






}