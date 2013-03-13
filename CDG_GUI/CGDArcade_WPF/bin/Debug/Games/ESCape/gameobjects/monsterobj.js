function MonsterObj()
{
    this.monsterX;
    this.monsterY;
    this.spriteX;
    this.spriteY;
    this.moveSpriteToX;
    this.moveSpriteToY;
    this.timertick;

    easeValue = 0.9; //0.5


    this.monsterState = 0;  // 0 = free, 1 = locked
    this.monsterType = 0;   // 0 = normal, 1 = super
    this.updateTimer;
    this.state0 = "sprites/red_40x40.png";    //red regular monster
    this.state1 = "sprites/darkred_40x40.png";    //darkred super monster
	this.mySprite;
    this.visible = true;



    this.initializeObject = function(monsterx, monstery) {
		this.monsterX = monsterx;
        this.monsterY = monstery;
        this.spriteX = monsterx * 40;
        this.spriteY = monstery * 40;
        this.monsterState = 0;
	}

    //this.setMonsterType = function() {
    //    var randMonster = Math.round(0 + Math.random()*(4-0));
    //    if (randMonster == 1){
    //        this.monsterType = 1;
    //        this.mySprite.src = this.state1;
    //    }
    //}

    //this.setMonsterUpdateTimer = function() {
    //    console.log("setMonsterUpdateTimer");
    //    this.updateTimer = setInterval(this.updateMonster, 1000);
    //}

	this.initializeSprite = function() {
		this.mySprite = new Image();
        this.mySprite.src = this.state0;
	}



	this.drawSprite = function() {
		if (this.visible) {
			theContext.drawImage(this.mySprite, this.spriteX, this.spriteY)
		}
	}



    this.updateMonster = function() {
        //console.log("updateMonster " + " : " + this.monsterState);

        if (this.monsterState == 0) {
            this.dumbMonsterMovement();
        } else {
            this.moveMonsterSprite();
        }
    }


    this.dumbMonsterMovement = function() {
       // console.log("DUMB");
        var randMonster = Math.round(0 + Math.random()*(4-0));

        switch(randMonster)
        {
        case 0:
          this.moveLeft();
          break;
        case 1:
          this.moveRight();
          break;
        case 2:
          this.moveUp();
          break;
        case 3:
          this.moveDown();
          break;
        default:
          //DO NOTHING
        }
    }





    this.moveLeft = function() {
        if((window.mazeArray[this.monsterX -1][this.monsterY].tileState == 0) || (window.mazeArray[this.monsterX -1][this.monsterY].tileState == 3)){
            //console.log("updatemonster EMPTY MAZE");
            this.monsterState = 1;
            this.monsterX = this.monsterX - 1;
            this.setMoveToCoords();
        }
    }


    this.moveRight = function() {
        if((window.mazeArray[this.monsterX + 1][this.monsterY].tileState == 0) || (window.mazeArray[this.monsterX + 1][this.monsterY].tileState == 3)){
            //console.log("updatemonster EMPTY MAZE");
            this.monsterState = 1;
            this.monsterX = this.monsterX + 1;
            this.setMoveToCoords();
        }
    }


    this.moveUp = function() {
        if((window.mazeArray[this.monsterX][this.monsterY - 1].tileState == 0) || (window.mazeArray[this.monsterX][this.monsterY - 1].tileState == 3)){
            //console.log("updatemonster EMPTY MAZE");
            this.monsterState = 1;
            this.monsterY = this.monsterY - 1;
            this.setMoveToCoords();
        }
    }


    this.moveDown = function() {
        if((window.mazeArray[this.monsterX][this.monsterY + 1].tileState == 0) || (window.mazeArray[this.monsterX][this.monsterY + 1].tileState == 3)){
            //console.log("updatemonster EMPTY MAZE");
            this.monsterState = 1;
            this.monsterY = this.monsterY + 1;
            this.setMoveToCoords();
        }
    }





    this.setMoveToCoords = function() {
        //this.moveSpriteSpeed = 20;

        this.moveSpriteToX = mazeArray[this.monsterX][this.monsterY].spriteX;
        this.moveSpriteToY = mazeArray[this.monsterX][this.monsterY].spriteY;
    }


    this.moveMonsterSprite = function() {
        //console.log("movemonsterSprite");

        var dx = this.moveSpriteToX - this.spriteX;
        var dy = this.moveSpriteToY - this.spriteY;

        var velocityX = dx * easeValue;
        var velocityY = dy * easeValue;

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
            this.monsterState = 0;
        }
    }




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