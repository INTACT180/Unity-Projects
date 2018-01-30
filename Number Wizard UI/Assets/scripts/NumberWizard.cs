using UnityEngine;	
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	public Text text;
	public int maxGuessesAllowed = 5;
	
	
	int max ;
	int min ;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame()
	{
		max = 1000;
		min = 1;
		guess = (int)Random.Range (min,max) ;	
		text.text = guess.ToString();
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();
	
	}
	
	public void GuessLower()
	{
		max = guess;
		NextGuess ();
	}
	
	void NextGuess()
	{
		guess = Random.Range (min,max);
		text.text = guess.ToString();
		maxGuessesAllowed -= 1;
		
		if (maxGuessesAllowed <= 0){
			Application.LoadLevel ("Win");
		}
		
		
	}
}
