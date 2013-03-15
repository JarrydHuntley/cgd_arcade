function TerrainTile()
{
    var arrayX;
    var arrayY;

    var spriteX;
    var spriteY;
    var spriteHeight;
    var spriteWidth;
    var spriteState = 0;

    var R = 0;
    var G = 0;
    var B = 0;
    var A = 0;

    var terrainType;
    var terrainCode;

    var monsterChance;
    var questNode;

    this.initializeObject = function(xStart, yStart, worldSizeY, worldSpriteHeight, worldSpriteWidth) {
        this.questNode = false;
        this.R = new Array();
        this.G = new Array();
        this.B = new Array();
        this.A = new Array();


        this.spriteHeight = worldSpriteHeight;
        this.spriteWidth = worldSpriteWidth;

        this.arrayX = xStart;
        this.arrayY = yStart;

        this.spriteX = xStart * this.spriteWidth;
        this.spriteY = yStart * this.spriteHeight;

        this.initializeSprite();

        this.spriteState = xStart % 30; //THIS SHOULD GIVE US A STAGGERED POINT...
        //TODO could we do an angle instead...? LATER
    }


    this.InitializeAsCapacitor = function(){
        this.terrainType = "Capacitor Forest";
        this.terrainCode = 0;
        this.monsterChance = 30;

        for(var i = 0; i < 30; i++)
        {
            this.R[i]  = 138;
            this.G[i]  = 175;
            this.B[i]  = 227;
            this.A[i]  = 255;
        }
    }

    this.InitializeAsChip = function(){
        this.terrainType = "Processor Castle";
        this.terrainCode = 1;
        this.monsterChance = 0;

        for(var i = 0; i < 30; i++)
        {
            this.R[i]  = 87;
            this.G[i]  = 91;
            this.B[i]  = 100;
            this.A[i]  = 255;
        }
    }

    this.InitializeAsCircuit = function(){
        this.terrainType = "Circuit Road";
        this.terrainCode = 2;
        this.monsterChance = 20;

        //"GLOW"
        for(var i = 0; i < 25; i++)
        {
            this.R[i]  = 241;
            this.G[i]  = 195;
            this.B[i]  = 133;
            this.A[i]  = 255;
        }

        for(var i = 25; i < 30; i++)
        {
            this.R[i]  = 255;
            this.G[i]  = 212;
            this.B[i]  = 13;
            this.A[i]  = 255;
        }
    }

    this.InitializeAsLed = function(){
        this.terrainType = "LED Ruins";
        this.terrainCode = 3;
        this.monsterChance = 50;

        for(var i = 0; i < 30; i++)
        {
            this.R[i]  = 206;
            this.G[i]  = 213;
            this.B[i]  = 223;
            this.A[i]  = 255;
        }
    }

    this.InitializeAsResistor = function(){
        this.terrainType = "Resistor Swamp";
        this.terrainCode = 4;
        this.monsterChance = 70;

        for(var i = 0; i < 30; i++)
        {
            this.R[i]  = 244;
            this.G[i]  = 174;
            this.B[i]  = 79;
            this.A[i]  = 255;
        }
    }


    this.initializeSprite  = function(){
        //DEFAULT TO SILICON GREY
        this.terrainType = "Silicon Desert";
        this.terrainCode = 5;
        this.monsterChance = 10;

        for(var i = 0; i < 30; i++)
        {
            this.R[i]  = 128;
            this.G[i]  = 128;
            this.B[i]  = 128;
            this.A[i]  = 255;
        }
    }






    this.updateTerrain = function() {
        this.spriteState = this.spriteState + 1;
        if (this.spriteState >= 30)
        {
            this.spriteState = 0;
        }

    }






    this.ReInitializeAsActiveLed = function(){
        this.terrainType = "LED Beacon";
        for(var i = 0; i < 30; i++)
        {
            this.R[i]  = 216;
            this.G[i]  = 62;
            this.B[i]  = 70;
            this.A[i]  = 255;
        }
    }

    /*
    this.initializeSprite  = function(){
        /*this.R  = Math.round(0 + Math.random()*(255-0));
        this.G  = Math.round(0 + Math.random()*(255-0));
        this.B  = Math.round(0 + Math.random()*(255-0));
        this.A  = Math.round(0 + Math.random()*(255-0));  //DO WE NEED THIS?

        this.A  = 255;
        var mapHeightIncrement = worldSizeY / 10;

        if (this.arrayY <= mapHeightIncrement )
        {
            //POLAR
            this.R  = 255;
            this.G  = 255;
            this.B  = 255;
        } else if (this.arrayY <= (mapHeightIncrement * 2)) {
            //TUNDRA

        } else if (this.arrayY <= (mapHeightIncrement * 3)) {
            //MOUNTAIN
            this.R  = 64;
            this.G  = 64;
            this.B  = 64;
        } else if (this.arrayY <= (mapHeightIncrement * 4)) {
            //FOREST
            this.R  = 44;
            this.G  = 82;
            this.B  = 62;
        } else if (this.arrayY <= (mapHeightIncrement * 5)) {
            //GRASSLAND
            this.R  = 134;
            this.G  = 217;
            this.B  = 160;
        } else if (this.arrayY <= (mapHeightIncrement * 6)) {
            //GRASSLAND
            this.R  = 134;
            this.G  = 217;
            this.B  = 160;
        } else if (this.arrayY <= (mapHeightIncrement * 7)) {
            //FOREST
            this.R  = 44;
            this.G  = 82;
            this.B  = 62;

        } else if (this.arrayY <= (mapHeightIncrement * 8)) {
            //MOUNTAIN
            this.R  = 64;
            this.G  = 64;
            this.B  = 64;

        } else if (this.arrayY <= (mapHeightIncrement * 9)) {
           //TUNDRA
            this.R  = 128;
            this.G  = 128;
            this.B  = 128;

        } else if (this.arrayY <= (mapHeightIncrement * 10)) {
            //POLAR
            this.R  = 255;
            this.G  = 255;
            this.B  = 255;

        }

    }*/


}