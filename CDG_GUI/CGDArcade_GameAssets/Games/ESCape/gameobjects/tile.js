function Tile()
{
    this.tileX;
    this.tileY;
    this.spriteX;
    this.spriteY;

    this.populated = false;
    
    this.tileState = 0;
    this.state0 = "sprites/black_40x40.png";    //empty
    this.state1 = "sprites/lightgrey_40x40.png"; //wall does not move on refresh
    this.state2 = "sprites/blue_40x40.png";    //wall
    this.state3 = "sprites/yellow_40x40.png";   //goal
	this.mySprite;
    this.visible = true;
    this.flagForRefresh = true;

    this.initializeObject = function(tilex, tiley) {
		this.tileX = tilex;
        this.tileY = tiley;
        this.spriteX = tilex * 40;
        this.spriteY = tiley * 40;
        this.initializeSprite();
	}

	this.initializeSprite = function() {
		this.mySprite = new Image();
	}



    
    this.updateTileState = function(state) {
        if(this.tileState != 1 && this.tileState != 3){

            var randomWall = Math.round(0 + Math.random()*(100-0));

            if ((randomWall >= 0) && (randomWall < 50)) {
                this.tileState = 0;
                this.mySprite.src = this.state0;
                this.setForRefresh();
            } else {
                this.tileState = 2;
                this.mySprite.src = this.state2;
                this.setForRefresh();
            }
        }
    }


    this.setToGoalState = function() {
        this.tileState = 3;
        this.mySprite.src = this.state3;
        this.setForRefresh();
    }

    this.setToPermanentWallState = function() {
        this.tileState = 1;
        this.mySprite.src = this.state1;
        this.setForRefresh();
    }

    this.resetToNormalState = function() {
        this.tileState = 0;
        this.mySprite.src = this.state0;
        this.setForRefresh();
    }





	this.drawSprite = function() {
		if ((this.visible) && (this.flagForRefresh == true)) {
			theContext.drawImage(this.mySprite, this.spriteX, this.spriteY)
		}
	}


    this.setForRefresh = function() {
        this.flagForRefresh = true;
    }


	this.setInvisible = function() {
		this.visible = false;
	}

	this.setVisible = function() {
		this.visible = true;
	}


}