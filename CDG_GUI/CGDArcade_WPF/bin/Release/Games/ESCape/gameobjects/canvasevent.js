function CanvasEvent()
{
	
	
	this.myGameObject;
	this.myDisplayedObject;
	this.myFunctionCall;
	
	
	this.myGameState = "";
	this.myEventType = "";
	this.myZOrder = 0;
	this.active = false;
    
    
    
    
    
	this.createEvent = function(state, eventtype, zorder, gameobj, displayobj, funccall) {
		this.myGameState = state;
		this.myEventType = eventtype;
		this.myZOrder = zorder;
		
		this.myGameObject = gameobj;
		this.myDisplayedObject = displayobj;
		this.myFunctionCall = funccall;
	}
	
	this.setEventActive = function() {
		this.active = true;
	}

	this.setEventInactive= function() {
		this.active = false;
	}

	//this.triggerEvent = function(e) {
	//	this.myFunctionCall(e);
	//}
	


}