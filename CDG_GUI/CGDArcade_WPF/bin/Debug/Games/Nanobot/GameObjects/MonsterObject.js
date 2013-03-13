function MonsterObject()
{
    var spriteX;
    var spriteY;
    var sprite;

    var toHit;
    var atk;
    var hp;
    var name;
    var stunned;


    this.initializeObject = function() {
        this.spriteX = -1000;  //TODO NEED MID TO VIEWPORT
        this.spriteY = 0;
        this.stunned = false;

        this.initializeSprite();
        this.generateMonster();
	}


    this.initializeSprite = function() {
        this.sprite = new Image();
        this.sprite.onload = function() {
            monsterObject.alignSpritePosition();
        }
    }

    this.alignSpritePosition = function(){
        this.spriteX = 500 - (this.sprite.width / 2);
        this.spriteY = 280 - (this.sprite.height);
    }

    this.updateObject = function() {
            //TODO PLACEHOLDER
    }

    this.drawSprite = function() {
        if(this.sprite.src != "")
        {
            theContext.drawImage(this.sprite, this.spriteX, this.spriteY);
        }
    }


    this.generateMonster = function() {
        var monsterRoll  = Math.round(0 + Math.random()*(2-0));

        switch(monsterRoll){
            case 0: //MINIBOT
                this.sprite.src = "Images/MinBot.8Bit.50pct.png";
                this.toHit = 30;
                this.atk = 1;
                this.hp = 2;
                this.name = "MiniBot";
                actionportObject.displayText("A MiniBot repair drone approaches...");
                break;
            case 1: //GORILLABOT
                this.sprite.src = "Images/GorillaBot.8Bit.50pct.png";
                this.toHit = 40;
                this.atk = 2;
                this.hp = 4;
                this.name = "GorillaBot";
                actionportObject.displayText("A GorillaBot heavy lifter approaches...");
                break;
            case 2: //TANKBOT
                this.sprite.src = "Images/Tank.8Bit.50pct.png";
                this.toHit = 50;
                this.atk = 2;
                this.hp = 4;
                this.name = "Tank";
                actionportObject.displayText("A TankBot defense drone approaches...");
                break;
        }
    }







}