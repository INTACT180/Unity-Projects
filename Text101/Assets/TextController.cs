using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum  States {
		cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0
	};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
				
		if      (myState == States.cell) 			cell();
		else if (myState == States.mirror) 			mirror();
		else if (myState == States.sheets_0) 		sheets_0();
		else if (myState == States.lock_0) 			lock_0();
		else if (myState == States.cell_mirror) 	cell_mirror();
		else if (myState == States.sheets_1) 		sheets_1();
		else if (myState == States.lock_1) 			lock_1();
		else if (myState == States.corridor_0) 		corridor_0();
		
	}
	
	#region StateHandlerMethods
	void cell()
	{
		text.text = "You are trapped in a dirty cell with only a mirror and a bed. " +
			"How can you escape this prediciment!!! Lets see if we can find a " +
			"way out! The door is locked from the outside.\n\n"+
			"Press S to view sheets, M to view the mirror, or L to examine the lock";
			
		if(Input.GetKeyDown(KeyCode.S))		{ myState = States.sheets_0;}
		else if(Input.GetKeyDown(KeyCode.M)){ myState = States.mirror;}
		else if(Input.GetKeyDown(KeyCode.L)){ myState = States.lock_0;}
	}
	
	void mirror()
	{
		text.text = "A small mirror reflects your poor prisoner self. " +
					"Your eyes are filled with the sadness of your prediciment... " +
					"It almost seems like this mirror could fit through the bars of the cell."+
					"\n\nPress T to take the piece of mirror or R to return to your cell.";
		
		if(Input.GetKeyDown(KeyCode.R))		{ myState = States.cell;}
		else if(Input.GetKeyDown(KeyCode.T)){ myState = States.cell_mirror;}
	}
	
	void sheets_0()
	{
		text.text = "These sheets are incredibly disgusting! There is a giant " + 
					"yellow stain in the middle amonst a floral design. Although " +
					"the design is trying its best I don't think it's helping much!" +
					"\n\nPress R to return to your cell";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
		
	}
	
	void lock_0()
	{
		text.text = "You examine the lock attached to the outside of the cell. " +
					"It doesn't seem like anything special. A simple turnable lock. " +
					"This is probably the cave of a kobold or something of the like. " +
					"If only you could turn that lock!\n\n"+
					"Press R to return to your cell";
		
		if(Input.GetKeyDown(KeyCode.R))		{ myState = States.cell;}
	}
	
	void cell_mirror()
	{
		text.text = "You grasp the mirror in your hands! You suddenly feel filled with POWER. " +
					"A smile creeps up onto your lips.... Geez dude its just a piece of mirror calm down. "+
					"Your cell is just as borring as ever. \n\n" +
					"Press S to examine sheets, or L to examine the lock.";
					
		if(Input.GetKeyDown(KeyCode.S))		        { myState = States.sheets_1;}
		else if(Input.GetKeyDown(KeyCode.L))		{ myState = States.lock_1;}
		
	}
	
	void sheets_1()
	{
		text.text = "Examine the sheets with a new found confidence. " +
					"With this newfound perspective.... yeah nevermind these " +
					"are still incredibly gross...\n\n" +
					"Press R to return to the cell";
		
		if(Input.GetKeyDown(KeyCode.R))		{ myState = States.cell_mirror;}
	}
	
	void lock_1()
	{
		text.text = "You rexamine the lock. It appears like the mirror could maybe " +
					"fit through the bars are twist the lock... just maybe. " +
					"\n\nPress O to open the lock or press R to return to the Cell";
		
		if      (Input.GetKeyDown(KeyCode.R))		{ myState = States.cell_mirror;}
		else if (Input.GetKeyDown(KeyCode.O))		{ myState = States.corridor_0;}
	}
	
	void corridor_0()
	{
		text.text = "The lock twists and the door swings open! It appears you are free " +
					"suck it kobolds!!! hahaha\n\n" +
					"You have escaped!! congrats! Press P to play again";
		
		if      (Input.GetKeyDown(KeyCode.P))		{ myState = States.cell;}
	}
	
	#endregion
	
}
