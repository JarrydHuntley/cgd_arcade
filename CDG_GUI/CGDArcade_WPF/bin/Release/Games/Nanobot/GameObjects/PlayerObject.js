function PlayerObject()
{
    var arrayX;
    var arrayY;
    var prevX;
    var prevY;

    var spriteX;
    var spriteY;
    var spriteHeight;
    var spriteWidth;
    var spriteState = 0;

    var moveSpeed = 1;
    var dirtyFlag;

    var R = 0;
    var G = 0;
    var B = 0;
    var A = 0;

    var toHit;
    var atk;
    var hp;

    this.playerState = "NONE";

    this.initializeObject = function(xStart, yStart, worldSpriteHeight, worldSpriteWidth) {
        console.log("createPlayerObject");

        this.arrayX = xStart;
        this.arrayY = yStart;

        this.spriteHeight = worldSpriteHeight;
        this.spriteWidth = worldSpriteWidth;

        this.updateMapSpritePosition();

        this.spriteState = 0;

        this.initializeSprite();

        this.toHit = 30;
        this.atk = 1;
        this.hp = 10;
    }

    this.initializeSprite  = function(){
        /*this.R  = Math.round(0 + Math.random()*(255-0));
        this.G  = Math.round(0 + Math.random()*(255-0));
        this.B  = Math.round(0 + Math.random()*(255-0));
        this.A  = Math.round(0 + Math.random()*(255-0));  //DO WE NEED THIS?*/
        this.A  = 255;
    }


    this.updateMapSpritePosition = function() {
        this.spriteX = this.arrayX * this.spriteWidth;
        this.spriteY = this.arrayY * this.spriteHeight;
    }




    this.flickerSpriteColor = function() {
        //console.log("Flicker " + this.spriteState);
        if (this.spriteState == 0) {
            //WHITE
            this.R  = 255;
            this.G  = 255;
            this.B  = 255;
        } else if (this.spriteState == 1) {
            //RED
            this.R  = 255;
            this.G  = 0;
            this.B  = 0;
        } else if (this.spriteState == 2) {
            //WHITE
            this.R  = 255;
            this.G  = 255;
            this.B  = 255;
        } else if (this.spriteState == 3) {
            //BLUE
            this.R  = 0;
            this.G  = 148;
            this.B  = 255;
        } else if (this.spriteState == 4) {
            //WHITE
            this.R  = 255;
            this.G  = 255;
            this.B  = 255;
        } else {
            //YELLOW
            this.R  = 182;
            this.G  = 255;
            this.B  = 0;
            this.spriteState = -1;
        }

        this.spriteState = this.spriteState + 1;
    }



    this.drawSprite = function() {
        theContext.drawImage(this.mySprite, this.spriteX, this.spriteY)
    }


    this.updatePlayer = function()
    {
        this.flickerSpriteColor();

        if (monsterObject == null)
        {
            this.prevX = this.arrayX;
            this.prevY = this.arrayY;

            // UP
            if (keyPressTrack == 38) {
                //console.log("updateplayer UP KEY");
                if (this.arrayY > 1)
                {
                    this.arrayY = this.arrayY - 1;
                    this.dirtyFlag = true;
                }
            }
            // LEFT
            if (keyPressTrack == 37) {
                //console.log("updateplayer LEFT KEY");
                if (this.arrayX > 1)
                {
                    this.arrayX = this.arrayX - 1;
                    this.dirtyFlag = true;
                }
            }
            // DOWN
            if (keyPressTrack == 40) {
                //console.log("updateplayer DOWN KEY");
                if (this.arrayY < worldObject.worldSizeY )
                {
                    this.arrayY = this.arrayY + 1;
                    this.dirtyFlag = true;
                }
            }
            // RIGHT
            if (keyPressTrack == 39) {
                //console.log("updateplayer RIGHT KEY");
                if (this.arrayX < worldObject.worldSizeX )
                {
                    this.arrayX = this.arrayX + 1;
                    this.dirtyFlag = true;
                }
            }

            if (this.dirtyFlag == true)
            {
                //UPDATE VIEWPORT
                viewportObject.updatePortState(worldObject.worldArray[this.arrayX][this.arrayY].terrainCode);

                //STANDING ON A CIRCUIT / HEAL
                if (worldObject.worldArray[this.arrayX][this.arrayY].terrainCode == 2)
                {
                    if (this.hp < 10) {
                        this.hp = this.hp + 1;
                        actionportObject.displayText("The charge of the circuit heals you to " + this.hp + " HP");
                    }
                    if (this.hp < 10) {
                        this.hp = 10;
                    }
                }

                //UPDATE MAP SPRITE
                this.updateMapSpritePosition();

                //UPDATE CREATE A MONSTER?
                var monsterRoll  = Math.round(0 + Math.random()*(100-0));
                console.log("MONSTER " + monsterRoll + ":" + worldObject.worldArray[this.arrayX][this.arrayY].monsterChance)
                if (monsterRoll <= worldObject.worldArray[this.arrayX][this.arrayY].monsterChance)
                {
                    monsterObject = new MonsterObject();
                    monsterObject.initializeObject();
                }
            }
        }
        this.dirtyFlag = false;
        keyPressTrack = 0;
    }





}