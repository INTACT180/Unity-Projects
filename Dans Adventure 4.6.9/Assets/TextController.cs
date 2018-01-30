using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class TextController : MonoBehaviour {
	
	private enum States{ 
		nemo_0,customer_I0, button_0, bottle_0, nemo_1, button_1,
		stare_0, customer_I1, boss_0, boss_attack, explode_0, boss_stumble,
		boss_stabbed, boss_dead_0, customer_I2, bathroom_0, bathroom_locked,
		bottle_1, key_found, boss_dead_1, bathroom_1, bathroom_2, explode_1,
		stare_c, customer_I3
		};
	private States myState;	
	
	public Text text;
	// Use this for initialization
	void Start () {
		myState = States.nemo_0;
	}
	
	// Update is called once per frame
	void Update () {
	
		if     (myState == States.nemo_0)			{nemo_0();}
		else if(myState == States.customer_I0)		{customer_I0();}
		else if(myState == States.button_0)			{button_0();}
		else if(myState == States.button_1)			{button_1();}
		else if(myState == States.bottle_0)			{bottle_0();}
		else if(myState == States.nemo_1)			{nemo_1();}
		else if(myState == States.stare_0)			{stare_0();}
		else if(myState == States.customer_I1)		{customer_I1();}
		else if(myState == States.boss_0)			{boss_0();}
		else if(myState == States.boss_attack)		{boss_attack();}
		else if(myState == States.explode_0)		{explode_0();}
		else if(myState == States.boss_stumble)		{boss_stumble();}
		else if(myState == States.boss_stabbed)		{boss_stabbed();}
		else if(myState == States.boss_dead_0)		{boss_dead_0();}
		else if(myState == States.customer_I2)		{customer_I2();}
		else if(myState == States.bathroom_0)		{bathroom_0();}
		else if(myState == States.bathroom_locked)	{bathroom_locked();}
		else if(myState == States.bottle_1)			{bottle_1();}
		else if(myState == States.key_found)		{key_found();}
		else if(myState == States.boss_dead_1)		{boss_dead_1();}
		else if(myState == States.customer_I3)		{customer_I3();}
		else if(myState == States.bathroom_1)		{bathroom_1();}
		else if(myState == States.bathroom_2)		{bathroom_2();}
		else if(myState == States.explode_1)		{explode_1();}
		else if(myState == States.stare_c)			{stare_c();}
	
	}
	
	#region Game State Methods
	
	void nemo_0()
	{
		text.text = "You are Dan working the Finding Nemo ride over " +
					"at epcot. The atmosphere is bland and lines short as "+
					"the usual queue of zero forms to board the ride. " + 
					"A few customers are coming to board the ride and a big red " +
					"button shines on the podium in front of you. "+ 
					"You also seem a little parched. \n\n" +
					"Press P to Press the button, I to Interact with the Customers,"+
					" or B to take out your water bottle.";
		if      (Input.GetKeyDown(KeyCode.P)) { myState = States.button_0;}
		else if (Input.GetKeyDown(KeyCode.I)) { myState = States.customer_I0;}
		else if (Input.GetKeyDown(KeyCode.B)) { myState = States.bottle_0;}
	}
	void button_0()
	{
		text.text = "Determined to do your job you confidently press the button " +
					"in front of you. And!!!!! nothing. nothing happens. They have this " +
					"button here so it appears that you actually do something. " +
					"But you don't do garbage. \n\n" +
					"Press R to return to doing nothing.";
		if      (Input.GetKeyDown(KeyCode.R)) { myState = States.nemo_0;}
	}
	
	void customer_I0()
	{
		text.text = "You smile at the customers coming to enjoy the fantasitc nemo ride. " +
					"They smile back with an intense ferocity. You've caught yourself in a staring contest!!!\n\n" +
					"Press S to Stare intensely back because by god you are winning this.";
		if      (Input.GetKeyDown(KeyCode.S)) { myState = States.stare_c;}
	}
	
	void stare_c()
	{
		text.text = "You smirk and stare intensely back at the customer! " +
					"Ha they don't stand a chance. They look away confused. " +
					"As they walk away you hear them mubbling about what a " +
					"weirdo you are. You assure yourself they are just sore losers.\n\n"+
					"Press R to Return to doing nothing.";
					
		if      (Input.GetKeyDown(KeyCode.R)) { myState = States.nemo_0;}
	}
	
	void bottle_0()
	{
		text.text = "You take out your water bottle and contemplate drinking.\n\n" +
					"Press D to Drink from the bottle or R to Return to doing nothing.";
		
		if      (Input.GetKeyDown(KeyCode.R)) { myState = States.nemo_0;}
		else if (Input.GetKeyDown(KeyCode.D)) { myState = States.nemo_1;}
	}
	
	void nemo_1()
	{
		text.text = "You forgot you had filled your bottle with MTN DEW, your " +
					"one true weakness!! You sudenly realize you have to pee.. bad " +
					"but you just went ten minutes ago. Your boss will be a bitch about it.\n\n"+
					"Press P to Press the button again, I to interact with customers or B to attempt " +
					"to go to the bathroom." ;
		
		if      (Input.GetKeyDown(KeyCode.P)) { myState = States.button_1;}
		else if (Input.GetKeyDown(KeyCode.B)) { myState = States.boss_0;}
		else if (Input.GetKeyDown(KeyCode.I)) { myState = States.customer_I1;}
	}
	
	void button_1()
	{
		text.text = "You press the button out of frustration and anger. "+
					"Oh no the button wasn't meant to be used in this way. " +
					"The gods warned you what would happen. Yeah nothing happens. " +
					"Its still just a useless button. Your boss seems iritated and is " +
					"staring at you with disappointment. \n\n" + 
					"Press R to Return to your work meekly, or S to Stare back intensely.";
		
		if      (Input.GetKeyDown(KeyCode.R)) { myState = States.nemo_1;}
		else if (Input.GetKeyDown(KeyCode.S)) { myState = States.stare_0;}
	}
	
	void stare_0()
	{
		text.text = "You stare intensely and angerly at your boss. He " +
					"seems uncomfortable and mumbles about how you're a werido. " +
					"You seem reassured about your place in the social structure as " +
					"he looks away akwardly. Stop staring at people.. \n\n" +
					"Press R to Return to your work of doing nothing and having to pee";
		
		if      (Input.GetKeyDown(KeyCode.R)) { myState = States.nemo_1;}
	}
	
	void customer_I1()
	{
		text.text = "You attempt to interact with the customers but due to the state of things. "+
					"You only make slight grunting noises and saucy jig. Customers seem inpressed " +
					"by your new found dance moves.\n\n" +
					"Press R to Return to your work with new found dancing prowess.";
		
		if      (Input.GetKeyDown(KeyCode.R)) { myState = States.nemo_1;}
	}
	
	void boss_0()
	{
		text.text = "You attempt to rush off to the bathroom but your boss cuts you off. " +
					"He standing in your way to freedom and release. Mumbling about how " +
					"you just went and couldn't have to go again so soon. As he drones on " +
					"about personal responsiblity you hand forms into a fist.\n\n"+
					"Press P to Punch him in the face, or R to Return meekly to your work.";
				
		if      (Input.GetKeyDown(KeyCode.R)) { myState = States.nemo_1;}
		else if (Input.GetKeyDown(KeyCode.P)) { myState = States.boss_attack;}
	}
	
	void boss_attack()
	{
		text.text = "Your boss stumbles back clearly confused from your baby punch (-1hp). " +
					"He chuckles and says you've really got it comming now and ready's a kick " +
					"aimed at your stomach. \n\n" +
					"Press T to Take the hit, or press D to attempt to dodge.";
		
		if      (Input.GetKeyDown(KeyCode.D)) { myState = States.boss_stumble;}
		else if (Input.GetKeyDown(KeyCode.T)) { myState = States.explode_0;}
	}
	
	void boss_stumble()
	{
		text.text = "As you dodge his kick he stumbles forward not anticipating your swift moves. " +
					"In his stumble you make a decision. You grasp the pencil in your pocket within " +
					"your fist.\n\nPress A to Attack your boss with the pencil.";
		
		if      (Input.GetKeyDown(KeyCode.A)) { myState = States.boss_stabbed;}
	}
	
	void boss_stabbed()
	{
		text.text = "You attack him with pencil stabbing him in the stomach. Blood rains down " +
					"from the heavens and you hold your blood ridden pencil. Your boss falls over " +
					"defeated. Geez dude, I mean he probably would of let you go... you didn't have " +
					"to go and kill the guy.\n\nPress C to Continue.";
		
		if      (Input.GetKeyDown(KeyCode.C)) { myState = States.boss_dead_0;}
	}
	
	void explode_0()
	{
		text.text = "He successfully kicks your stomach damaging your already full bladder. " +
					"The hit was stronger than you expected.. You explode into a million pieces "+
					"leaving Dan debis all over the walls. Should of dodged I guess.\n\n" +
					"Game Over... Press P to play again.";
		
		if      (Input.GetKeyDown(KeyCode.P)) { myState = States.nemo_0;}
	}
	
	void boss_dead_0()
	{
		text.text = "You bosses' bloody body taints the floor of the once fun* filled Nemo ride. " +
					"The customers look upon in awe and fear. You have dethroned the evil king boss. " +
					"Just kidding you killed an innocent person. What is wrong with you....\n\n" +
					"Press I to Interact with the customers, B to rush to the Bathroom, or S to Search your boss.\n\n\n"+
					"*disclaimer: nemo ride was never fun.";
		
		if      (Input.GetKeyDown(KeyCode.I)) { myState = States.customer_I2;}
		else if (Input.GetKeyDown(KeyCode.B)) { myState = States.bathroom_0;}
		else if (Input.GetKeyDown(KeyCode.S)) { myState = States.key_found;}
	}
	
	void bathroom_0()
	{
		text.text = "You rush to the bathroom since you have just about reached the limit. " +
					"Finally you arrive at the bathroom door. The door is carved from stove " +
					"harvested from the dwaves after the 6th Disney/Dwaven war of 87. " +
					"It looms above you as you reach for the handle.\n\n"+
					"Press O to Open the bathroom door";
		
		if      (Input.GetKeyDown(KeyCode.O)) { myState = States.bathroom_locked;}
	}
	
	void bathroom_locked()
	{
		text.text = "THE HANDLE DOESN'T TURN. THE DOOR IS LOCKED. This a massive miscalculation on your part. "+
					"You quickly do the bathroom jig trying to win the doors favor but it is not amused. You " +
					"suddenly remember, the bottle! You could attempt to relieve yourself using the bottle.\n\n"+
					"Press B to use the Bottle or R to Return." ;
		
		if      (Input.GetKeyDown(KeyCode.B)) { myState = States.bottle_1;}
		else if (Input.GetKeyDown(KeyCode.R)) { myState = States.boss_dead_0;}
	}
	
	void bottle_1()
	{
		text.text = "You attempt to utilize the bottle in a genius bit of wit. "+
					"However in attempting to utilize it there is one very tiny problem. " +
					"The size of the tool to do the job is far to small to be able to find " +
					"an adequate solution. This just won't work. " +
					"Someone walks by in the meantime and mumbles around how you're a weirdo. "+
					"Jokes on them, you would of been crowned a genius by the genius corp if this idea had worked.\n\n"+
					"Press R to Return to find a new solution."  ;
		
		if (Input.GetKeyDown(KeyCode.R)) { myState = States.boss_dead_0;}
	}
	
	void key_found()
	{
		text.text = "You search your bosses dead body and find... a key!.\n\n" + 
					"Press T to take the Key or R to Return.";
					
		if      (Input.GetKeyDown(KeyCode.T)) { myState = States.boss_dead_1;}
		else if (Input.GetKeyDown(KeyCode.R)) { myState = States.boss_dead_0;}
	}
	
	void boss_dead_1()
	{
		text.text = "You grasp the key in your hand. This is it finally. The fabeled " +
					"bathroom key you had heard legends of finally within your hands. " +
					"Your bosses body lies on the floor pooling up more blood. The customers gasp " +
					"and whisper about the legend of the bathroom.\n\n" +
					"Press I to Interact with customers, or B to go to the Bathroom.";
		
		if      (Input.GetKeyDown(KeyCode.I)) { myState = States.customer_I3;}
		else if (Input.GetKeyDown(KeyCode.B)) { myState = States.bathroom_1;}
	}
	
	void customer_I2()
	{
		text.text = "You hold the mechanical pencil up in the air and roar. The customers " +
					"applaud in awe and fear. Before boarding the nemo ride " +
					"whose waters have turned a deep ruby red.\n\n" +
					"Press R to Return";
		
		if      (Input.GetKeyDown(KeyCode.R)) { myState = States.boss_dead_0;}
	}
	
	void customer_I3()
	{
		text.text = "You do a saucy jig with the key in hand. The customers are incredibly " +
					"impressed that in addition to combat skills you have such refined dance moves. " +
					"Empowered by your newfound following you up the antics on your dance pallet. " +
					"While trying to impress the customers with even newer moves you slip and fall. " + 
					"The customers are slightly less impressed by their newfound god.\n\n" +
					"Press R to Return.";
		
		if      (Input.GetKeyDown(KeyCode.R)) { myState = States.boss_dead_1;}
		
	}
	
	void bathroom_1()
	{
		text.text = "You rush to the bathroom since you have just about reached the limit. " +
				"Finally you arrive at the bathroom door. The door is carved from stove " +
				"harvested from the dwaves after the 6th Disney/Dwaven war of 87. " +
				"It looms above you as you reach for the handle, key in hand.\n\n"+
				"Press O to Open the bathroom door, R to Return.";
		
		if      (Input.GetKeyDown(KeyCode.O)) { myState = States.bathroom_2;}
		else if (Input.GetKeyDown(KeyCode.R)) { myState = States.boss_dead_1;}
	}
	
	void bathroom_2()
	{
		text.text = "As you turn the key the door splits open and light blinds you. " +
					"Angels sing as an average slightly dirty Disney bathroom graces your eyes. " +
					"Your limit has almost been reached. You rush to the stall.\n\n"+
					"Press R to Rush.";
		
		if (Input.GetKeyDown(KeyCode.R)) { myState = States.explode_1;}
	}
	
	void explode_1()
	{
		text.text = "You rush straight to the stall. But alas. too late. " +
					"With the combined activity from earlier you can take no more. " +
					"You explode into a million pieces. Please forever remember Dan.\n\n" +
					"Game over (true end) ... Press P to play again";
		
		if (Input.GetKeyDown(KeyCode.P)) { myState = States.nemo_0;}
	}
	
	
	
	
	
	#endregion
}






