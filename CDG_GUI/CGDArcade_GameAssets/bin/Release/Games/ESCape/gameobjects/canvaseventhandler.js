function CanvasEventHandler() 
{
	
	this.customEventArray = [];	
    
    
    
    
	
	this.AddCustomEventHandler = function(state, eventtype, zorder, gameobj, displayobj, funccall) {
		
		var newEvent = new CanvasEvent();
		
		newEvent.createEvent(state, eventtype, zorder, gameobj, displayobj, funccall); 
		
		this.customEventArray.push(newEvent);
		
		return this.customEventArray.length;
	}


	this.PurgeAllEvents = function(){
		this.customEventArray = [];
	}
	
	
	function include(arr,obj) {
    	return (arr.indexOf(obj) != -1);	
	}
	
	
	
	this.TriggerCanvasEvent = function(event, eventtype){
        
  		if (touchEnabled) {
			xCoord = event.touches[0].pageX;
			yCoord = event.touches[0].pageY;
		} else{
			xCoord = event.pageX;
        	yCoord = event.pageY;
		};
        
		
		//Debugger.log("  TriggerCanvasEvent X: " + touchX + " Y: " + touchY, touchX, touchY + "TYPE " + eventtype);
		//alert("TriggerCanvasEvent : " + eventtype);
		
		for (var i=0; i < this.customEventArray.length; i++) {
		  
		  
		  if (this.customEventArray[i].myGameState == gameState) {
		  	//Debugger.log("       GAMESTATE Verified");
		  	if (this.customEventArray[i].myEventType == eventtype) {
		  		//Debugger.log("       EVENTTYPE Verified");
		  		if (this.customEventArray[i].myGameObject.visible == true) {
		  			//Debugger.log("       EVENTTYPE Verified... Again..?");	
		  			
		  			if (xCoord >= parseInt(this.customEventArray[i].myGameObject.x) && xCoord <= (parseInt(this.customEventArray[i].myGameObject.x) + parseInt(this.customEventArray[i].myDisplayedObject.width))) {
		  				//Debugger.log("       touchX Verified");
		  				
		  				if (yCoord >= parseInt(this.customEventArray[i].myGameObject.y) && yCoord <= (parseInt(this.customEventArray[i].myGameObject.y) + parseInt(this.customEventArray[i].myDisplayedObject.height))) {
		  					//Debugger.log("TriggerCanvasEvent FOUND!");
							this.customEventArray[i].myFunctionCall(event, eventtype);  
							return;					
		  				}
		  			}

		  		}
		  	}
		  }
		  
		  
		};
	}

}