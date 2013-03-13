function WorldObject()
{
    var worldArray;
    var worldSizeX;  //ZERO START
    var worldSizeY;

    var terrainSpriteHeight;
    var terrainSpriteWidth;

    var resistorTrackingArray;
    var capacitorTrackingArray;
    var chipTrackingArray;
    var questTracker;
    var ledTrackingArray;


    this.createWorld = function(){

        this.worldSizeX = 40;
        this.worldSizeY = 40;
        this.terrainSpriteWidth = 5;
        this.terrainSpriteHeight = 5;

        var tempTerrainObject;
        this.worldArray = new Array(this.worldSizeX);

        for (var x=1; x <= this.worldSizeX; x++) {
            this.worldArray[x] = new Array(this.worldSizeY);

            for (var y=1; y <= this.worldSizeY; y++) {
                tempTerrainObject = new TerrainTile();
                tempTerrainObject.initializeObject(x,y, this.worldSizeY, this.terrainSpriteWidth, this.terrainSpriteHeight);
                this.worldArray[x][y] = tempTerrainObject;
            }
        }

        this.AddCoolStuffToWorld();
    }

    this.AddCoolStuffToWorld = function() {

        var randomItem;
        var startComponent;
        var endComponent;

        this.resistorTrackingArray = new Array();
        this.capacitorTrackingArray = new Array();
        this.chipTrackingArray = new Array();
        this.ledTrackingArray = new Array();

        //CREATE RESISTORS - BLUE
        for(var i = 0; i <= 10; i++)
        {
            var randomX  = Math.round(1 + Math.random()*(this.worldSizeX-1));
            var randomY  = Math.round(1 + Math.random()*(this.worldSizeY-1));
            var terrain = this.worldArray[randomX][randomY];
            terrain.InitializeAsResistor();
            this.resistorTrackingArray[i] = terrain;
        }

        //CREATE CAPACITORS - GREEN
        for(var i = 0; i <= 10; i++)
        {
            var randomX  = Math.round(1 + Math.random()*(this.worldSizeX-1));
            var randomY  = Math.round(1 + Math.random()*(this.worldSizeY-1));
            var terrain = this.worldArray[randomX][randomY];
            terrain.InitializeAsCapacitor();
            this.capacitorTrackingArray[i] = terrain;
        }

        //CREATE CHIPS - DARK GREY
        for(var i = 0; i <= 10; i++)
        {
            var randomX  = Math.round(1 + Math.random()*(this.worldSizeX-1));
            var randomY  = Math.round(1 + Math.random()*(this.worldSizeY-1));
            var terrain = this.worldArray[randomX][randomY];
            terrain.InitializeAsChip();
            this.chipTrackingArray[i] = terrain;
        }
        //  SET THE QUEST NODE
        randomItem  = Math.round(0 + Math.random()*(this.chipTrackingArray.length-1));
        var questChip = this.chipTrackingArray[randomItem];
        questChip.questNode = true;
        this.questTracker = questChip;

        //CREATE LED RUINS - WHITE
        for(var i = 0; i <= 10; i++)
        {
            var randomX  = Math.round(1 + Math.random()*(this.worldSizeX-1));
            var randomY  = Math.round(1 + Math.random()*(this.worldSizeY-1));
            var terrain = this.worldArray[randomX][randomY];
            terrain.InitializeAsLed();
            this.ledTrackingArray[i] = terrain;
        }


        //CREATE CIRCUITS
        for(var i = 0; i <= 5; i++)
        {
            //GET STARTING COMPONENT
            var randomStartComponent  = Math.round(1 + Math.random()*(4-1));
            switch (randomStartComponent){
                case 1:
                    randomItem  = Math.round(0 + Math.random()*(this.resistorTrackingArray.length-1));
                    startComponent = this.resistorTrackingArray[randomItem];
                    break;
                case 2:
                    randomItem  = Math.round(0 + Math.random()*(this.capacitorTrackingArray.length-1));
                    startComponent = this.capacitorTrackingArray[randomItem];
                    break;
                case 3:
                    randomItem  = Math.round(0 + Math.random()*(this.chipTrackingArray.length-1));
                    startComponent = this.chipTrackingArray[randomItem];
                    break;
                case 4:
                    randomItem  = Math.round(0 + Math.random()*(this.ledTrackingArray.length-1));
                    startComponent = this.ledTrackingArray[randomItem];
                    break;
            }


            //GET ENDING COMPONENT
            do
              {
                  var randomEndComponent  = Math.round(1 + Math.random()*(4-1));
              }
            while (randomStartComponent==randomEndComponent);

            switch (randomEndComponent){
                case 1:
                    randomItem  = Math.round(0 + Math.random()*(this.resistorTrackingArray.length-1));
                    endComponent = this.resistorTrackingArray[randomItem];
                    break;
                case 2:
                    randomItem  = Math.round(0 + Math.random()*(this.capacitorTrackingArray.length-1));
                    endComponent = this.capacitorTrackingArray[randomItem];
                    break;
                case 3:
                    randomItem  = Math.round(0 + Math.random()*(this.chipTrackingArray.length-1));
                    endComponent = this.chipTrackingArray[randomItem];
                    break;
                case 4:
                    randomItem  = Math.round(0 + Math.random()*(this.ledTrackingArray.length-1));
                    endComponent = this.ledTrackingArray[randomItem];
                    break;
            }

            var xIncrement;
            var yIncrement;

            if (startComponent.arrayX < endComponent.arrayX) {
                xIncrement = 1;
            } else  if (startComponent.arrayX > endComponent.arrayX) {
                xIncrement = -1;
            } else {
                xIncrement = 0;
            }

            if (startComponent.arrayY < endComponent.arrayY) {
                yIncrement = 1;
            } else  if (startComponent.arrayY > endComponent.arrayY) {
                yIncrement = -1;
            } else {
                yIncrement = 0;
            }


            for (var x = startComponent.arrayX; x != endComponent.arrayX; x = x + xIncrement)
            {
                if (this.worldArray[x][startComponent.arrayY].terrainType = "Silicon Desert")
                {
                    this.worldArray[x][startComponent.arrayY].InitializeAsCircuit();
                }
            }

            for (var y = startComponent.arrayY; y != endComponent.arrayY; y = y + yIncrement)
            {
                if (this.worldArray[endComponent.arrayX][y].terrainType = "Silicon Desert")
                {
                    this.worldArray[endComponent.arrayX][y].InitializeAsCircuit();
                }
            }
        }
    }



}